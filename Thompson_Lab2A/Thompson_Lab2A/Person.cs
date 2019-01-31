using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class Person
    {
        private string name, address, phoneNumber, emailAddress;

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
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public Person(string newName, string newAddress, string newPhoneNum, string newEmail)
        {
            Name = newName;
            Address = newAddress;
            PhoneNumber = newPhoneNum;
            EmailAddress = newEmail;
        }

        public Person ()
        {
            Name = " ";
            Address = " ";
            PhoneNumber = " ";
            EmailAddress = " ";
        }

        public override string ToString()
        {
            return "Person: " + Name + " | " + Address + " | " + PhoneNumber + " | " + EmailAddress;
        }
    }
}
