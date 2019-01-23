using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Testing_Area
{
    class TestParent
    {
        public int somenumber = 6;


        public TestParent ()
        {

        }

        public virtual int someMethod (int x)
        {
            return x + 5;
        }
    }

}
