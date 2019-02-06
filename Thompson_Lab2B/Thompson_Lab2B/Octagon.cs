using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2B
{
    class Octagon : GeometricObject
    {
        private double sideLength;

        public double SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        public Octagon(double sideL)
        {
            SideLength = sideL;
        }

        public Octagon()
        {
            SideLength = -1.00;
        }

        public override double Area()
        {
            return 2 * (1 + Math.Sqrt(2)) * SideLength * SideLength;
        }

        public override double Perimeter()
        {
            return 8 * SideLength;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public override int CompareTo(object obj)
        {
            Octagon otherOctagon = obj as Octagon;
            return this.SideLength.CompareTo(otherOctagon.SideLength);
        }
    }
}