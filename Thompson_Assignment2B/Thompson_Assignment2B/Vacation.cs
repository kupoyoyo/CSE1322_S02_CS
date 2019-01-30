using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment2B
{
    abstract class Vacation
    {
        private double budget;
        private string destination;

        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public Vacation (double b, string d)
        {
            Budget = b;
            Destination = d;
        }

        public Vacation()
        {
            Budget = -1.0;
            Destination = " ";
        }

        public abstract double BudgetCheck();
    }
}
