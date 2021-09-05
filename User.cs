using System;
using System.Collections.Generic;
using System.Text;


namespace webCalendar
{
    public class User
    {
        public int Id { get; set; }
        public string nickName { get; set; }
        private List<Calendar> calendarList;
        public User(int id,string name)
        {
            Id = id;
            nickName = name;
            calendarList = new List<Calendar>();
        }
        public User(int id)
        {
            Id = id;
            
        }

        protected bool addCalendar(Calendar c)
        {
            bool ans = true;
            calendarList.Add(c);
            return ans;
        }
        public string print()
        {
            return "User: " + nickName + " id: " + Id ;
        }


        

    }
}
