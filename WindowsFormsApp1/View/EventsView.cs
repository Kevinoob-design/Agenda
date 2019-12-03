using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using WindowsFormsApp1.View;

namespace View
{
    public partial class EventsView : Form
    {
        Dictionary<string, string> info = new Dictionary<string, string>();

        List<Event> listEvent = new List<Event>();

        public EventsView()
        {
            InitializeComponent();

            refill();

            foreach (var item in Enum.GetValues(typeof(Repeat)))
            {
                comboBoxRepeat.Items.Add(item);
                comboBoxRepeat.SelectedIndex = 0;
            }
            foreach (var item in Enum.GetValues(typeof(Alert)))
            {
                comboBoxAlert.Items.Add(item);
                comboBoxAlert.SelectedIndex = 0;
            }

            comboBoxTimeStart.SelectedIndex = 0;

            init(null, "Select_Events");
        }

        private void refill()
        {
            comboBoxTimeEnd.Items.Clear();

            foreach (var item in comboBoxTimeStart.Items)
            {
                comboBoxTimeEnd.Items.Add(item);
            }
        }

        private void init(Dictionary<string, string> items, string spName)
        {
            listEvent = Conexion.Load<Event>(items, spName);
            listBoxContacts.Items.Clear();

            foreach (Event item in listEvent)
            {
                listBoxContacts.Items.Add($"{item.tittle} {item.startDate}");
            }

            if (listBoxContacts.Items.Count != 0)
            {
                listBoxContacts.SelectedIndex = 0;

                setChildWithValue<Event>(listBoxContacts.SelectedIndex, MainPanel);
            }

            info.Clear();
        }

        private void comboBoxTimeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            refill();

            comboBoxTimeEnd.SelectedIndex = comboBoxTimeStart.SelectedIndex;

            List<object> list = new List<object>();

            for (int i = 0; i < comboBoxTimeEnd.SelectedIndex; i++)
            {
                int memory = comboBoxTimeEnd.SelectedIndex;
                comboBoxTimeEnd.SelectedIndex = i;
                list.Add(comboBoxTimeEnd.SelectedItem);
                comboBoxTimeEnd.SelectedIndex = memory;
            }
            foreach (var item in list)
            {
                comboBoxTimeEnd.Items.Remove(item);
                comboBoxTimeEnd.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            info.Add(comboBoxTimeStart.Tag.ToString(), monthCalendar1.SelectionStart.ToString("MM/dd/yy"));
            info.Add(comboBoxTimeEnd.Tag.ToString(), monthCalendar1.SelectionEnd.ToString("MM/dd/yy"));           

            getChildWithValue(MainPanel);

            Conexion.Save(info, "SP_Insertar_Eventos");
            init(null, "Select_Events");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listEvent = Conexion.Load<Event>(null, "Select_Events");
        }

        private void getChildWithValue(params Control[] control)
        {
            foreach (var item in control)
            {
                if (item is Button || item is Label)
                {

                }
                else
                {
                    if (item.Tag != "" && item.Text != "")
                    {
                        if (!info.ContainsKey(item.Tag.ToString()))
                        {
                            info[item.Tag.ToString()] = item.Text;
                        }
                        else
                        {

                            info[item.Tag.ToString()] += " " + item.Text;
                        }
                    }
                }

                IEnumerable<Control> containers = item.Controls.OfType<Control>();

                if (containers != null)
                {
                    foreach (var child in containers)
                    {
                        getChildWithValue(child);
                    }
                }
            }
        }

        private void setChildWithValue<T>(int i, params Control[] control)
        {
            foreach (var item in control)
            {
                if (item.Tag != null && item.Tag != "")
                {
                    Type type = typeof(T);
                    item.Text = type.GetProperty(item.Tag.ToString()).GetValue(listEvent[i]).ToString();
                }

                IEnumerable<Control> containers = item.Controls.OfType<Control>();

                if (containers != null)
                {
                    foreach (var child in containers)
                    {
                        setChildWithValue<T>(i, child);
                    }
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblRange.Visible = true;
            lblRange.Text = $"Start: {monthCalendar1.SelectionStart.ToString("MM/dd/yy")} - End: {monthCalendar1.SelectionEnd.ToString("MM/dd/yy")}";
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            setChildWithValue<Event>(listBoxContacts.SelectedIndex, MainPanel);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactListRemove ct = new ContactListRemove();
            ct.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ContactListRemove ctr = new ContactListRemove();
            ctr.Show();
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.Add("eventID", listEvent[listBoxContacts.SelectedIndex].eventID);
            Conexion.Save(info, "SP_Eliminar_Eventos");
            init(null, "Select_Events");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            info.Add("eventID", listEvent[listBoxContacts.SelectedIndex].eventID);
            getChildWithValue(MainPanel);

            Conexion.Save(info, "SP_Modificar_Eventos");
            init(null, "Select_Events");
        }
    }
}
