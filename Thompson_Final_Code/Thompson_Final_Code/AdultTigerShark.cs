using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Final_Code
{
    public class AdultTigerShark : Shark
    {
        public AdultTigerShark(string n, int l, int w)
        {
            Name = n;

            if (l < 10)
                Length = 10;
            else if (l > 13)
                Length = 13;
            else
                Length = l;

            if (w < 849)
                Weight = 849;
            else if (w > 1400)
                Weight = 1400;
            else
                Weight = w;
        }

        public override string SharkFood()
        {
            Random rnd = new Random();
            int food = rnd.Next(15, 41);
            Weight += food;
            return Name + " ate a large sea turtle and gained " + food + "lbs.";
        }
    }
}
