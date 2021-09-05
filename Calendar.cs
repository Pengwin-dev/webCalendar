using System;
using System.Collections.Generic;
using System.Text;

namespace webCalendar
{
    class Calendar
    {
        public string name { get; set; }
        public List<DateEntry> days;
        public Calendar(string n)
        {
            name = n;
            days = new List<DateEntry>();
        }
        
    }
}
