using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number4
    {
        private string[] myInts;

        public Number4(string newInts)
        {
            myInts = newInts.Split(' ');
        }

        public void getResult()
        {
            var result = from s in myInts
                         where s.Length == 2
                         where s[0] != '-'
                         select s;
            if (result.Count() > 0)
            {
                foreach (string s in result)
                {
                    Console.Write(s + " ");
                }
            }
            else Console.WriteLine("0");
        }
    }
}
