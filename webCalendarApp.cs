﻿using System;
using System.Collections.Generic;
using System.Text;

namespace webCalendar
{
    class webCalendarApp
    {
        public int Id { get; set; }
        private List<User> userList;
        private List<Calendar> calendarList;

        public webCalendarApp(int id)
        {
            Id = id;
        }

        public List<User> getUserList()
        {
            return userList;
        }
        public List<Calendar> getCalendarList()
        {
            return calendarList;
        }
        

        //UsersCollection
        //
        //CalendarCollection
        //constructor
        //delete
        //addNewCalendar
        //addNewUser
        //


    }
}
