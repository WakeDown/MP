using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number7
    {
        private List<int> a;
        private List<int> b;
        private int k1, k2;
        private List<int> result;

        public Number7(List<int> newIntsA, List<int> newIntsB, int k1, int k2)
        {
            result = new List<int>();
            a = newIntsA;
            b = newIntsB;
            this.k1 = k1;
            this.k2 = k2;
        }

        public void getResult()
        {
            var res = (from i in a
                           where i > k1
                           select i).Concat(from i in b
                                            where i < k2
                                            select i);
            
            foreach (int i in res)
            {
                result.Add(i);
            }
            result.Sort();
            foreach (int i in result)
            {
                Console.Write(i + ",");
            }
        }
    }
}
