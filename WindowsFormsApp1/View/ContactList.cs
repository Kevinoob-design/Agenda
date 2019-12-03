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
        public ContactList()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {

        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            Conexion.LoadDataContact(dgvContactList);
        }
    }
}
