using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number7
    {
        int x;
        int y;
        int z;

        String result;

        public Number7(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            comparison();
        }

        private int sum()
        {
            return x + y + z;
        }

        private int mult()
        {
            return x * y * z;
        }

        void comparison()
        {
            if (sum() > mult()) result = ("Сумма " + sum() + " больше произведения " + mult());
            if (sum() < mult()) result = ("Сумма " + sum() + " меньше произведения " + mult());
            else result = ("Сумма " + sum() + " равна произведению " + mult());
        }

        public String getResult()
        {
            return result;
        }
    }
}
