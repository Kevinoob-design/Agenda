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
    public partial class ContactList : Form
    {
        private static string eventoID;

        public ContactList()
        {
            InitializeComponent();
        }
        public ContactList(Event evento)
        {
            InitializeComponent();
            eventoID = evento.eventID.ToString();
        }
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            var contact = dgvContactList.CurrentRow.Cells["contactID"].Value.ToString();
            Conexion.InsertarRelacion(Convert.ToInt32 (contact), Convert.ToInt32(eventoID) );

            this.Close();
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            Conexion.LoadDataContact(dgvContactList);
        }
    }
}
