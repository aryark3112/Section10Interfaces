﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section5._12
{
    public class Teacher : IPerson
    {
        private string name;
        private string address;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

        public string getInfo()
        {
            string retVal = "Name: " + name + ", Address=" + address + ", Joining Date =" + dateOfJoining.ToShortDateString();
            return retVal;
        }

        public string getTypeOfPerson()
        {
            return "teacher";
        }
    }
}


