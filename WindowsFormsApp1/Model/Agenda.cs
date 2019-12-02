using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Agenda
    {
        /// <summary>
        /// An unique ID to display the propper Contacts and Events for the agendada that is selected.
        /// </summary>
        public string _agendaID { get; }

        public Agenda(string agendaID)
        {
            _agendaID = agendaID;
        }
    }
}
