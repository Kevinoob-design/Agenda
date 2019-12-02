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
using View.ChildEventView.ChildYearView;

namespace View.ChildEventView
{
    public partial class YearEventView : Form
    {
        public YearEventView(ISelfConfigureCell cell)
        {
            InitializeComponent();

            for (int i = 1; i < 13; i++)
            {
                cell = new YearView(i);

                BringFormChild(cell, MainPanel);
            }
        }

        public void BringFormChild(object FormHijo, TableLayoutPanel panel)
        {
            //if (panel.Controls.Count > 0)
            //{
            //    panel.Controls.RemoveAt(0);
            //}

            Form NewForm = FormHijo as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            panel.Controls.Add(NewForm);
            panel.Tag = NewForm;
            NewForm.Show();
        }
    }
}
