using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace WindowsFormsApp1.View
{
    public partial class SplitMainView : Form
    {
        public SplitMainView()
        {
            InitializeComponent();

            BringFormChild(new EventsView(), MainPanel);
            BringFormChild(new AgendaView(), MainPanel);
        }

        public void BringFormChild(object FormHijo, TableLayoutPanel panel)
        {
            //if (panel.Controls.Count > 0)
            //{
            //    panel.Controls.RemoveAt(0);
            //}

            Form NewForm = FormHijo as Form;
            NewForm.TopLevel = false;
            //NewForm.Dock = DockStyle.Fill;
            NewForm.Anchor = AnchorStyles.Top;
            panel.Controls.Add(NewForm);
            panel.Tag = NewForm;
            NewForm.Show();
        }
    }
}
