using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab5B
{
    class Clothes
    {
        private string name;
        private string color;
        private bool highTempWash;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool HighTempWash
        {
            get { return highTempWash; }
            set { highTempWash = value; }
        }
        public Clothes (string n, string c, bool h)
        {
            Name = n;
            Color = c;
            HighTempWash = h;
        }
        public Clothes ()
        {
            Name = "";
            Color = "";
            HighTempWash = false;
        }
        public bool EqualsColor(string c)
        {
            if (Color == c)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return Name + ", " + Color + ", high temp wash okay? " + HighTempWash;
        }
    }
}
