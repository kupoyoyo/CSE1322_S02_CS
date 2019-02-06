using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2B
{
    abstract class GeometricObject : IComparable, ICloneable
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract object Clone();
        public abstract int CompareTo(object obj);
    }
}