using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controller;
using Model;
using WindowsFormsApp1.View;

namespace View
{
    public partial class AgendaView : Form
    {
        List<Control> listControllers = new List<Control>();

        Dictionary<string, string> info = new Dictionary<string, string>();

        private List<Contact> contacts = new List<Contact>();

        public AgendaView()
        {
            InitializeComponent();
            listControllers.Add(groupBoxContactInfo);
            listControllers.Add(PanelAnotations);
            listControllers.Add(groupBoxAddress);

            init(null, listBoxContacts.Tag.ToString());
        }

        private void init(Dictionary<string, string> items, string spName)
        {
            contacts = Conexion.Load<Contact>(items, spName);
            listBoxContacts.Items.Clear();

            foreach (Contact item in contacts)
            {
                listBoxContacts.Items.Add($"{item.name} {item.lastName}");
            }

            if (listBoxContacts.Items.Count != 0)
            {
                listBoxContacts.SelectedIndex = 0;

                for (int i = 0; i < listControllers.Count(); i++)
                {
                    setValues<Contact>(listControllers[i], listBoxContacts.SelectedIndex);
                }
            }
        }

        private void UpdateBDD(object sender, EventArgs e)
        {
            Control send = (Control)sender;
            StoreProcedures sp = (StoreProcedures)Convert.ToInt32(send.Tag);

            switch (sp)
            {
                case StoreProcedures.Select_Contact_Info:
                    break;

                case StoreProcedures.SP___Guardar___Contact_Email_Direction_Number:
                    for (int i = 0; i < listControllers.Count(); i++)
                    {
                        getValues(listControllers[i]);
                    }
                    break;

                case StoreProcedures.SP___Eliminar___Contact_Email_Direction_Number:
                    info.Add("contactID", contacts[listBoxContacts.SelectedIndex].contactID);
                    break;

                case StoreProcedures.SP___Modificar___Contact_Email_Direction_Number:
                    info.Add("contactID", contacts[listBoxContacts.SelectedIndex].contactID);
                    for (int i = 0; i < listControllers.Count(); i++)
                    {
                        getValues(listControllers[i]);
                    }
                    break;

                case StoreProcedures.__Filtrar__Contacto:

                    info.Add("str", txtSearch.Text);

                    break;

                default:
                    break;
            }

            Conexion.Save(info, sp.ToString());
            init(null, listBoxContacts.Tag.ToString());
            info.Clear();
        }

        private void getValues(Control Control)
        {
            IEnumerable<TextBox> controles = Control.Controls.OfType<TextBox>();

            foreach (Control control in controles)
            {
                info.Add(control.Tag.ToString(), control.Text);
            }
        }

        private void setValues<T>(Control Control, int i)
        {
            IEnumerable<TextBox> controles = Control.Controls.OfType<TextBox>();

            foreach (var control in controles)
            {
                Type type = typeof(T);
                control.Text = type.GetProperty(control.Tag.ToString()).GetValue(contacts[i]).ToString();
            }
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listControllers.Count(); i++)
            {
                setValues<Contact>(listControllers[i], listBoxContacts.SelectedIndex);
            }

            AgendaView_Load(null, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Control send = (Control)sender;
            StoreProcedures sp = (StoreProcedures)Convert.ToInt32(send.Tag);
            info.Add("str", txtSearch.Text);
            init(info, sp.ToString());
            info.Clear();

            
        }

      
        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            EventList d = new EventList(contacts[listBoxContacts.SelectedIndex]);
            d.Show();

            AgendaView_Load(null, null);
        }

        private void AgendaView_Load(object sender, EventArgs e)
        {
            var rowsAmount = Conexion.countRows(contacts[listBoxContacts.SelectedIndex].contactID);
            lblEventCheck.Text = rowsAmount + " Events "; 
                                
        }

        private void btnCheckEvent_Click(object sender, EventArgs e)
        {
            Event_RelatedList d = new Event_RelatedList(contacts[listBoxContacts.SelectedIndex]);
            d.Show();

            AgendaView_Load(null, null);
        }

        //public void BringFormChild(object FormHijo, TableLayoutPanel panel)
        //{
        //    //if (panel.Controls.Count > 0)
        //    //{
        //    //    panel.Controls.RemoveAt(0);
        //    //}

        //    Form NewForm = FormHijo as Form;
        //    NewForm.TopLevel = false;
        //    NewForm.Dock = DockStyle.Fill;
        //    panel.Controls.Add(NewForm);
        //    panel.Tag = NewForm;
        //    NewForm.Show();
        //}
    }
}
