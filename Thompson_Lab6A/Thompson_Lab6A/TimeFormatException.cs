using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab6A
{
    class TimeFormatException : Exception
    {
        public TimeFormatException()
        {

        }

        public TimeFormatException(string time)
            : base ("There is no such time as: " + time)
        {

        }
    }
}
