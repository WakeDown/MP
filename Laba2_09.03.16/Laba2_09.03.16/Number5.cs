using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number5
    {
        private int k;
        private string[] a;

        public Number5(string newA, int k)
        {
            a = newA.Split(',');
            this.k = k;
        }

        public void getResult()
        {
            var result = from s in a
                         where s.Length == k
                         where Convert.ToInt32(s[s.Length - 1]) >= 0
                         where Convert.ToInt32(s[s.Length - 1]) <= 9
                         orderby s.Substring(0, 1)
                         select s;
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
