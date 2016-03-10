using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number9
    {
        private int[] newInts;

        public Number9(int[] n1, int[] n2)
        {
            this.newInts = n1.Union(n2).ToArray();
            Array.Sort(newInts);
        }

        public void getNewInts()
        {
            foreach (int i in newInts)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
