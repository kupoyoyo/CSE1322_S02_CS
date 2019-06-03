using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Final_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            AdultGreatWhiteShark agw1 = new AdultGreatWhiteShark("Bob", 12, 1600);
            AdultTigerShark at1 = new AdultTigerShark("Kim", 10, 950);
            BabyGreatWhiteShark bgw1 = new BabyGreatWhiteShark("Laura", agw1.Length, agw1.Weight);
            BabyTigerShark bt1 = new BabyTigerShark("Tim", at1.Length, at1.Weight);

            Console.WriteLine(agw1);
            Console.WriteLine(at1);
            Console.WriteLine(bgw1);
            Console.WriteLine(bt1);
        }
    }
}
