using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class EventsView : Form
    {
        public EventsView()
        {
            InitializeComponent();

            refill();

            comboBoxTimeEnd.SelectedIndex = comboBoxTimeStart.SelectedIndex;

            List<object> list = new List<object>();

            for (int i = 0; i < comboBoxTimeEnd.SelectedIndex; i++)
            {
                int memory = comboBoxTimeEnd.SelectedIndex;
                comboBoxTimeEnd.SelectedIndex = i;
                list.Add(comboBoxTimeEnd.SelectedItem);
                comboBoxTimeEnd.SelectedIndex = memory;
            }
            foreach (var item in list)
            {
                comboBoxTimeEnd.Items.Remove(item);
                comboBoxTimeEnd.Items.Add(item);
            }
        }

        private void refill()
        {
            comboBoxTimeEnd.Items.Clear();

            foreach (var item in comboBoxTimeStart.Items)
            {
                comboBoxTimeEnd.Items.Add(item);
            }
        }

        private void comboBoxTimeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            refill();

            comboBoxTimeEnd.SelectedIndex = comboBoxTimeStart.SelectedIndex;

            List<object> list = new List<object>();

            for (int i = 0; i < comboBoxTimeEnd.SelectedIndex; i++)
            {
                int memory = comboBoxTimeEnd.SelectedIndex;
                comboBoxTimeEnd.SelectedIndex = i;
                list.Add(comboBoxTimeEnd.SelectedItem);
                comboBoxTimeEnd.SelectedIndex = memory;
            }
            foreach (var item in list)
            {
                comboBoxTimeEnd.Items.Remove(item);
                comboBoxTimeEnd.Items.Add(item);
            }
        }
    }
}
