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

namespace View.ChildEventView.ChildMonthView
{
    public partial class MonthView : Form, ISelfConfigureCell
    {

        Dictionary<string, string> info = new Dictionary<string, string>();

        Event evento = new Event();

        public MonthView()
        {

        }

        public MonthView(int day, Event evento)
        {
            this.evento = evento;

            InitializeComponent();

            lblDay.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height-2, FontStyle.Regular);
            lblTittle.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            lblAlert.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            lblLocation.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            lblStart.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            lblEnd.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);
            lblDueDate.Font = new Font(lblTittle.Font.FontFamily, TopPanel.Font.Height, FontStyle.Regular);

            lblDay.Text = day.ToString();

            //setChildWithValue(MainPanel);
        }

        private void setChildWithValue(params Control[] control)
        {
            foreach (var item in control)
            {
                if (item is Label)
                {
                    if (item.Tag != null && item.Text != null)
                    {
                        if (!info.ContainsKey(item.Tag.ToString()))
                        {
                            //info[item.Tag.ToString()] = item.Text;

                            item.Text = "fucking";
                        }
                        else
                        {
                            item.Text = "fucking";
                            //info[item.Tag.ToString()] += " " + item.Text;
                        }
                    }
                }

                IEnumerable<Control> containers = item.Controls.OfType<Control>();

                if (containers != null)
                {
                    foreach (var child in containers)
                    {
                        setChildWithValue(child);
                    }
                }
            }
        }
    }
}
