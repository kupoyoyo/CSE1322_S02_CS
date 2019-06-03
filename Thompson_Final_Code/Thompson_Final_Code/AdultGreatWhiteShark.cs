using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Final_Code
{
    public class AdultGreatWhiteShark : Shark
    {
        public AdultGreatWhiteShark(string n, int l, int w)
        {
            Name = n;

            if (l < 10)
                Length = 10;
            else if (l > 21)
                Length = 21;
            else
                Length = l;

            if (w < 1500)
                Weight = 1500;
            else if (w > 2400)
                Weight = 2400;
            else
                Weight = w;
        }

        public override string SharkFood()
        {
            Random rnd = new Random();
            int food = rnd.Next(20, 51);
            Weight += food;
            return Name + " ate a tuna and gained " + food + "lbs.";
        }
    }
}
