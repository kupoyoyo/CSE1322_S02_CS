using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Final_Code
{
    public class BabyGreatWhiteShark : AdultGreatWhiteShark
    {
        public BabyGreatWhiteShark(string n, int l, int w)
        {
            Name = n;
            Length = l/2;
            Weight = w/2;
        }
    }
}
