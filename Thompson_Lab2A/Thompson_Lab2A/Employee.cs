using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class Employee : Person
    {
        private string office;
        private double salary;
        private MyDate dateHired;

        public string Office
        {
            get { return office; }
            set { office = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public MyDate DateHired
        {
            get { return dateHired; }
            set { dateHired = value; }
        }

        public Employee(string newName, string newAddress, string newPhoneNum, string newEmail, string newOffice, double newSalary, MyDate newDateHired)
        {
            Name = newName;
            Address = newAddress;
            PhoneNumber = newPhoneNum;
            EmailAddress = newEmail;
            Office = newOffice;
            Salary = newSalary;
            DateHired = newDateHired;
        }

        public Employee ()
        {
            Name = " ";
            Address = " ";
            PhoneNumber = " ";
            EmailAddress = " ";
            Office = " ";
            Salary = -1.0;
            DateHired = new MyDate();
        }

        public override string ToString()
        {
            return "Employee: " + Name + " | " + Address + " | " + PhoneNumber + " | " + EmailAddress + " | " + Office + " | $" + Salary + " | " + DateHired;
        }
    }
}
