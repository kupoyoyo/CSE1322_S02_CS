using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Joe", "123 Place Ave", "(344)867-4555", "joe@joe.org");
            Console.WriteLine(p1);

            Student s1 = new Student("Brianne", "22 City Place", "(128)554-3898", "notbrianne@aol.com", "Junior");
            Console.WriteLine(s1);

            MyDate d1 = new MyDate(2010, 8, 20);
            Employee e1 = new Employee("Adam", "3 Town Rd", "(942)587-9933", "workemail@office.com", "Work Inc", 32000, d1);
            Console.WriteLine(e1);

            MyDate d2 = new MyDate(2014, 3, 10);
            Faculty f1 = new Faculty("Ida", "844 Some Rd", "(422)145-8242", "ida12@workplaceemail.gov", "Big Corp", 87000, d2, "MWF 8:00-4:00", "Supervisor");
            Console.WriteLine(f1);

            MyDate d3 = new MyDate(2006, 10, 2);
            Staff st1 = new Staff("Erin", "1352 Apartment Circle", "(749)236-2664", "aaaaa@um.com", "Cash Money Intl", 152000, d3, "Manager");
            Console.WriteLine(st1);
        }
    }
}
