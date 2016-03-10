using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number2
    {
        List<string> myInts;
        int average, sum;

        public Number2(string newInts)
        {
            myInts = new List<string>(newInts.Split(','));
        }

        public int getMinimum()
        {
            myInts.Sort();
            return Convert.ToInt32(myInts[0]);
        }

        public int getMaximum()
        {
            myInts.Sort();
            return Convert.ToInt32(myInts[myInts.Count - 1]);
        }

        public int getSum()
        {
            sum = 0;
            foreach (string s in myInts)
            {
                sum += Convert.ToInt32(s);
            }
            return sum;
        }

        public int getAverage()
        {
            average = getSum() / myInts.Count;
            return average;
        }
    }
}
