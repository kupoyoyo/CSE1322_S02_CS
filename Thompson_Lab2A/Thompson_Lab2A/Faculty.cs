using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class Faculty : Employee
    {
        private string officeHours, rank;

        public string OfficeHours
        {
            get { return officeHours; }
            set { officeHours = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public Faculty(string newName, string newAddress, string newPhoneNum, string newEmail, string newOffice, double newSalary, MyDate newDateHired, string newOfficeHours, string newRank)
        {
            Name = newName;
            Address = newAddress;
            PhoneNumber = newPhoneNum;
            EmailAddress = newEmail;
            Office = newOffice;
            Salary = newSalary;
            DateHired = newDateHired;
            OfficeHours = newOfficeHours;
            Rank = newRank;
        }

        public Faculty()
        {
            Name = " ";
            Address = " ";
            PhoneNumber = " ";
            EmailAddress = " ";
            Office = " ";
            Salary = -1.0;
            DateHired = new MyDate();
            OfficeHours = " ";
            Rank = " ";
        }

        public override string ToString()
        {
            return "Faculty: " + Name + " | " + Address + " | " + PhoneNumber + " | " + EmailAddress + " | " + Office + " | $" + Salary + " | " + DateHired + " | " + OfficeHours + " | " + Rank;
        }
    }
}