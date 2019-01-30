using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment2B
{
    class AllInclusiveVacation : Vacation
    {
        private string brand;
        private int rating;
        private double price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public AllInclusiveVacation(double bu, string de, string br, int ra, double pr)
        {
            Budget = bu;
            Destination = de;
            Brand = br;
            Rating = ra;
            Price = pr;
        }

        public AllInclusiveVacation ()
        {
            Budget = -1.0;
            Destination = " ";
            Brand = " ";
            Rating = -1;
            Price = -1.0;
        }

        public override double BudgetCheck()
        {
            return Budget - Price;
        }
    }
}
