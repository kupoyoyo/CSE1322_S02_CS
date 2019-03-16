using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab5B
{
    class Food
    {
        private string name;
        private int calories;
        private int servings;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public int Servings
        {
            get { return servings; }
            set { servings = value; }
        }
        public Food(string n, int c, int s)
        {
            Name = n;
            Calories = c;
            Servings = s;
        }
        public Food()
        {
            Name = "";
            Calories = -1;
            Servings = -1;
        }
        public override string ToString()
        {
            return Name + ", Calories per serving: " + Calories + ", Servings: " + Servings;
        }
    }
}
