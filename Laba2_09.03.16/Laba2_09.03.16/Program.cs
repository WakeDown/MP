using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        private static void numb1()
        {
            string startBox = Console.ReadLine();
            Number1 number1 = new Number1(startBox);
            number1.readtText();
        }
    }
}
