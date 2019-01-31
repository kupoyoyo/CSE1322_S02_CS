using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class Staff : Employee
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Staff(string newName, string newAddress, string newPhoneNum, string newEmail, string newOffice, double newSalary, MyDate newDateHired, string newTitle)
        {
            Name = newName;
            Address = newAddress;
            PhoneNumber = newPhoneNum;
            EmailAddress = newEmail;
            Office = newOffice;
            Salary = newSalary;
            DateHired = newDateHired;
            Title = newTitle;
        }

        public Staff()
        {
            Name = " ";
            Address = " ";
            PhoneNumber = " ";
            EmailAddress = " ";
            Office = " ";
            Salary = -1.0;
            DateHired = new MyDate();
            Title = " ";
        }

        public override string ToString()
        {
            return "Staff: " + Name + " | " + Address + " | " + PhoneNumber + " | " + EmailAddress + " | " + Office + " | $" + Salary + " | " + DateHired + " | " + Title;
        }
    }
}
