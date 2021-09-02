using System;
using System.Collections.Generic;
using System.Text;


namespace webCalendar
{
    public class User
    {
        public int Id { get; set; }
        public string nickName { get; set; }
        public User(int id,string name)
        {
            Id = id;
            nickName = name;
        }
        public User(int id)
        {
            Id = id;
            
        }
        public string print()
        {
            return "str";
        }

        

    }
}
