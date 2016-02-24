using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number8
    {
        double x;
        double funcF;

        public Number8(double x)
        {
            this.x = x;
            startNumber();
        }

        void startNumber()
        {            
            if (x < 0) funcF = Math.Pow(x, 2) - 3 - Math.Pow(Math.PI - x, 1 / 3);
            if (x >= 1) funcF = x * (Math.Pow(x, 2) + 3) + Math.Log(Math.PI + x);
            else funcF = Math.Pow((Math.Pow(x, 2) + 3), 2) - Math.Sqrt(0.5 * Math.PI + x);
        }

        public double getFuncF()
        {
            return funcF;
        }
    }
}
