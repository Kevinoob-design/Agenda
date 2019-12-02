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

namespace View.ChildEventView.ChildYearView
{
    public partial class YearView : Form, ISelfConfigureCell
    {
        public YearView()
        {

        }

        public YearView(int month)
        {
            InitializeComponent();

            //lblDay.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            //lblTittle.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            //lblAlert.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            //lblLocation.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            //lblStart.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            //lblEnd.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);

            int days = DateTime.DaysInMonth(2019, month);

            for (int i = 1; i < days + 1; i++)
            {
                Label label = new Label();
                label.Text = i.ToString();
                label.Dock = DockStyle.Fill;

                MainPanel.Controls.Add(label);

                //if (MainPanel.Controls.Count == 7)
                //{
                //    MainPanel.Controls.Add(label, 2, 1);
                //}
                //else
                //{
                //    MainPanel.Controls.Add(label);
                //}
            }   
        }
    }
}
