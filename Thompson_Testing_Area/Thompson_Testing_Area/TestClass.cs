using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Testing_Area
{
    class TestClass
    {
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
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
