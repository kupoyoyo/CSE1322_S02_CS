using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab1A
{
    class Lab1A
    {
        static void Main(string[] args)
        {
            int frequency, duration; //declaring variables

            Console.WriteLine("Make sure your volume is on to hear the beep!");
            Console.Write("Please enter a frequency: ");
            frequency = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a duration (ms): ");
            duration = Int32.Parse(Console.ReadLine());

            Console.Beep(frequency, duration); //creates a computer beep using inputted frquency and duration
        }
    }
}
