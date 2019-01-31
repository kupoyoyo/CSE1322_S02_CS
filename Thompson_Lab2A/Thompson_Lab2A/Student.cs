using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class Student : Person
    {
        private string classStatus;

        public string ClassStatus
        {
            get { return classStatus; }
            set { classStatus = value; }
        }

        public Student (string newName, string newAddress, string newPhoneNum, string newEmail, string newClassStatus)
        {
            Name = newName;
            Address = newAddress;
            PhoneNumber = newPhoneNum;
            EmailAddress = newEmail;
            ClassStatus = newClassStatus;
        }

        public Student ()
        {
            Name = " ";
            Address = " ";
            PhoneNumber = " ";
            EmailAddress = " ";
            ClassStatus = " ";
        }

        public override string ToString()
        {
            return "Student: " + Name + " | " + Address + " | " + PhoneNumber + " | " + EmailAddress + " | " + ClassStatus;
        }
    }
}
