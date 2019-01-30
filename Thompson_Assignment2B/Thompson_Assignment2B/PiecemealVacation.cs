using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment2B
{
    class PiecemealVacation : Vacation
    {
        private List<string> items = new List<string>();
        private List<double> costs = new List<double>();

        public List<string> Items
        {
            get { return items; }
            set { items = value; }
        }
        public List<double> Costs
        {
            get { return costs; }
            set { costs = value; }
        }

        public PiecemealVacation(double bu, string de, List<string> it, List<double> co)
        {
            Budget = bu;
            Destination = de;
            items.AddRange(it);
            costs.AddRange(co);
        }

        public PiecemealVacation()
        {
            Budget = -1.0;
            Destination = " ";
            Items.Add(" ");
            Costs.Add(-1);
        }

        public override double BudgetCheck()
        {
            double costTotal = 0;
            foreach(double element in Costs)
            {
                costTotal += element;
            }
            return Budget - costTotal;
        }
    }
}
