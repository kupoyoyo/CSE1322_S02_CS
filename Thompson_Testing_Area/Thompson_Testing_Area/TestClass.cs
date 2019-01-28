using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Testing_Area
{
    class TestClass
    {

        static int vehicleCount = 0; //Static makes it so that only ONE instance of this variable is created
        private int doors, speed;
        private string color;


        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public TestClass(int d, int s, string c)
        {
            Doors = d;
            Speed = s;
            Color = c;
        }

        public TestClass()
        {
            Doors = 4;
            Speed = 120;
            Color = "black";
            Console.WriteLine("The default class has been created");
            vehicleCount++;
            Console.WriteLine(vehicleCount + " vehicle(s) created");
        }

        public static void run ()
        {
            Console.WriteLine("The run() called...");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
