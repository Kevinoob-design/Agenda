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
        public EventList()
        {
            InitializeComponent();
        }

        public EventList(Contact contacts)
        {
            InitializeComponent();
            MessageBox.Show(contacts.contactID.ToString());
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            Conexion.LoadData(dgvEvents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvEvents.CurrentRow.Cells["eventID"].Value.ToString());
        }

        private void Algo(List<Contact> asd)
        {

        }
    }
}
