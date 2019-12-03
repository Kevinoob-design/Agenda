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
    public partial class EventList : Form
    {
        private string contactID;

        public EventList()
        {
            InitializeComponent();
        }

        public EventList(Contact contacts)
        {
            InitializeComponent();
            contactID = contacts.contactID.ToString();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            Conexion.LoadData(dgvEvents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string events = dgvEvents.CurrentRow.Cells["eventID"].Value.ToString();

            Conexion.InsertarRelacion(Convert.ToInt32( contactID ), Convert.ToInt32(events ) );

            this.Close();
        }
    }
}
