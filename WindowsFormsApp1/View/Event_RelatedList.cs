using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace WindowsFormsApp1.View
{
    public partial class Event_RelatedList : Form
    {
        private string contactID;

        public Event_RelatedList()
        {
            InitializeComponent();
        }
   
        public Event_RelatedList(Contact contacts)
        {

            InitializeComponent();
            contactID = contacts.contactID.ToString();

        }



        private void Event_RelatedList_Load(object sender, EventArgs e)
        {
            Conexion.LoadDataEvent(dgvEventsRelated,Convert.ToInt32 ( contactID ) );
            dgvEventsRelated.Columns["contactID"].Visible = false;
            dgvEventsRelated.Columns["personalNumber"].Visible = false;
            dgvEventsRelated.Columns["name"].Visible = false;
            dgvEventsRelated.Columns["lastName"].Visible = false;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            string events = dgvEventsRelated.CurrentRow.Cells["eventID"].Value.ToString();
            

            Conexion.EliminarRelacion(Convert.ToInt32(events)); 

            this.Close();
            
        }
    }
}
