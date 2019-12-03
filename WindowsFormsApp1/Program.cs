using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ChildEventView;
using View.ChildEventView.ChildMonthView;
using View.ChildEventView.ChildYearView;
using WindowsFormsApp1.View;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new AgendaView());
            Application.Run(new EventsView());

            //Application.Run(new MonthEventView(new MonthView()));

            //Application.Run(new DetailedEventView());
            //Application.Run(new YearEventView(new YearView()));
        }
    }
}
