using System;

/* must use:
Delegates and lambdas
Generics
General concepts 
Linq 
Interfaces
//
Formularios
Cicle detection on a Precedence Graph
 */

namespace webCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            webCalendarApp calendarAPP = new webCalendarApp(1);
            User u = calendarAPP->getUserList()->searchById(123); // return a user.
            Calendar c= u->getCalendarList()->getCalendarById(333); // return calendar of the previous user.
            

            Collectio<Reminder>
            //THE FOLLOWING METHODS RETURN A LIST OF REMINDERS.
            c->getReminders(DateTime d); //show some  reminders of the previous calendar.
            c->getReminders(string * tags[]) //show some reminders by a given tag(s).
            c->getReminders(int priority) // ggiven a priority betweeen 1-3. Show all reminders with that priority.
            c->getReminders(DateTime d, string * tags[], int priority); //Filter by that 3 categories.
            
            c->

        }
    }
}
