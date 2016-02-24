using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number2
    {
        int year;

        public Number2(int year)
        {
            this.year = year;
        }

        public String getResult()
        {
            if (DateTime.IsLeapYear(year))
                return "Введенный год является висококосным";
            else return "Введенный год НЕ является висококосным";
        }
    }
}
