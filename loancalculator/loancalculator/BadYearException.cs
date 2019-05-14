using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesse_demo
{
    public class BadYearException : Exception
    {
        public BadYearException(string msg) : base(msg)
        {
        }
    }
}
