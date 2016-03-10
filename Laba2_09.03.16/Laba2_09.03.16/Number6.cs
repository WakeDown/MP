using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number6
    {
        List<int> myInt;
        public Number6(string s)
        {
            myInt = new List<int>();
            string[] ints = s.Split(',');
            foreach(string st in ints)
            {
                myInt.Add(Convert.ToInt32(st));
            }
        }

        public void getResult()
        {
            var newA = myInt.Where((i, index) => (index % 3) == 1 || (index % 3) == 2);
            foreach (var s in newA)
            {
                Console.Write(s.ToString() + " ");
            }
        }
    }
}
