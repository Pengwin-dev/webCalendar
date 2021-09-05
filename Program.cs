using System;
using System.Linq;
using System.Collections;
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

            bool showMenu = true;
            webCalendarApp calendarAPP = new webCalendarApp(1);
            while (showMenu)
            {
                showMenu = MainMenu(calendarAPP);
            }

        }

        private static bool MainMenu(webCalendarApp calendarAPP)
        {

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add New User");
            Console.WriteLine("2) Show User By Id");
            Console.WriteLine("3) Create New Calendar on a User");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Get your Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Get your nickname:");
                    string nick = Console.ReadLine();
                    User u1 = new User(id, nick);
                    calendarAPP.addUser(u1);
                    return true;
                    
                case "2":
                    Console.WriteLine("Get the Id that you are looking for:");
                    int userID = Convert.ToInt32(Console.ReadLine());
                    User found =calendarAPP.getUserList().Find(x => x.Id == userID);
                    Console.WriteLine(found.print());
                    Console.ReadKey();
                    return true;

                case "3":
                    Console.WriteLine("Select the id:");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    User f = calendarAPP.getUserList().Find(x => x.Id == ID);
                    Calendar c = new Calendar("Calendario 1");
                    f.AddCalendar(c);
                    
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }


            
            // return a user.
        /*    User u = calendarAPP
                
        Calendar c= u->getCalendarList()->getCalendarById(333); // return calendar of the previous user.
            

            Collectio<Reminder>
            //THE FOLLOWING METHODS RETURN A LIST OF REMINDERS.
            c->getReminders(DateTime d); //show some  reminders of the previous calendar.
            c->getReminders(string * tags[]) //show some reminders by a given tag(s).
            c->getReminders(int priority) // ggiven a priority betweeen 1-3. Show all reminders with that priority.
            c->getReminders(DateTime d, string * tags[], int priority); //Filter by that 3 categories.
            
            c->
        */
        }
    }

