using System;

namespace webCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            webCalendarApp calendarAPP = new webCalendarApp();
            User u = calendarAPP->getUserList()->searchById(123); // return a user.
            Calendar c= u->getCalendarList()->getCalendarById(333); // return calendar of the previous user.
            c->printReminders(DateTime d); //show some  reminders of the previous calendar.
            c->printReminders(string* tags[]) //show some reminders by a given tag.
            c->

        }
    }
}
