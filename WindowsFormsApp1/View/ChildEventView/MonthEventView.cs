using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ChildEventView.ChildMonthView;
using View.ChildEventView.ChildYearView;
using Controller;
using Model;

namespace View.ChildEventView
{
    public partial class MonthEventView : Form
    {
        public MonthEventView(ISelfConfigureCell cell)
        {
            InitializeComponent();

            //MessageBox.Show(DateTime.Now.ToString());

            List<Event> eventList = new List<Event>();

            eventList = Conexion.Load<Event>(null, "Select_Events");

            //foreach (var item in eventList)
            //{
            //    MessageBox.Show(item.startDate);
            //    MessageBox.Show(item.endDate);
            //}

            for (int i = 1; i <= DateTime.DaysInMonth(2019, 12); i++)
            {
                //cell = new MonthView(i, eventList[i]);

                BringFormChild(cell, MainMonthPanel);
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

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            Form NewForm = new DetailedEventView() as Form;
            NewForm.Show(new DetailedEventView());
        }

        private void btnBackToYear_Click(object sender, EventArgs e)
        {
            Form NewForm = new YearEventView(new YearView()) as Form;
            NewForm.Show(new DetailedEventView());
        }
    }
}
