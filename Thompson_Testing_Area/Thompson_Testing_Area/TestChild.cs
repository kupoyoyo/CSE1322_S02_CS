using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Testing_Area
{
    class TestChild : TestParent
    {
        public override int someMethod(int x)
        {
            return x+ 45;
        }
    }
}
