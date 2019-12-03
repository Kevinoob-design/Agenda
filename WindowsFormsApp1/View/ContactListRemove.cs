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
    public partial class ContactListRemove : Form
    {

        private string eventoID;

        public ContactListRemove()
        {
            InitializeComponent();
        }

        public ContactListRemove(Event evento)
        {
            InitializeComponent();
            eventoID = evento.eventID.ToString();
        }
        private void btnREmoveContact_Click(object sender, EventArgs e)
        {
            string contact = dgvCOntactListRemove.CurrentRow.Cells["contactID"].Value.ToString();
            Conexion.EliminarRelacionEvento(Convert.ToInt32 ( contact ) );

            this.Close();
        }

        private void ContactListRemove_Load(object sender, EventArgs e)
        {
            Conexion.LoadDataContactRemove(dgvCOntactListRemove, Convert.ToInt32 (eventoID) );
        }
    }
}
