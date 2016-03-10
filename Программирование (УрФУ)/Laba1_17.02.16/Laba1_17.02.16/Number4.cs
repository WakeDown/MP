using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number4
    {
        DateTime myDateTime;
        String result = null;

        public Number4(int year, int month, int day, int hours, int minuts)
        {
            myDateTime = new DateTime(year, month, day, hours, minuts, 0, 0);
            subTime();
        }

        void subTime()
        {
            TimeSpan d = DateTime.Now.Subtract(myDateTime);
            result = (d.Days + " Дней "
                + (DateTime.Now.Subtract(myDateTime)).Hours + " Часов "
                + (DateTime.Now.Subtract(myDateTime)).Minutes + " Минут");
        }

        public String getResult()
        {
            return result;
        }
    }
}
