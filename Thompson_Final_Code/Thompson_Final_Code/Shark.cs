using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Final_Code
{
    public abstract class Shark
    {
        private string name;
        private int length;
        private int weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract string SharkFood();

        public override string ToString()
        {
            return "Shark name: " + Name + ". Length: " + Length + "ft. Weight: " + Weight + "lbs. " + SharkFood();
        }
    }
}
