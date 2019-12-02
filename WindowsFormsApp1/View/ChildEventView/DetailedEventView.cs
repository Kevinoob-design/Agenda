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

namespace View.ChildEventView
{
    public partial class DetailedEventView : Form
    {
        Dictionary<string, string> info = new Dictionary<string, string>();

        public DetailedEventView()
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

        private void refill()
        {
            comboBoxTimeEnd.Items.Clear();

            foreach (var item in comboBoxTimeStart.Items)
            {
                comboBoxTimeEnd.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getChildWithValue(tableLayoutPanel1);

            Conexion.Save(info, "SP_Insertar_Eventos");
            info.Clear();
        }

        private void getChildWithValue(params Control[] control)
        {   
            //List<Control> list = new List<Control>();

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
                        else{

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
    }
}
