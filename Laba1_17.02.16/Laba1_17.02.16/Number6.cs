using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number6
    {
        String[] intNum;
        int sum = 0;

        public Number6(String intStr)
        {
            intNum = intStr.Split(' ');
            sumInts();
        }

        void sumInts()
        {
            try {
                for (int i = 0; i < intNum.Length; i++)
                {
                    sum += Convert.ToInt32(intNum[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Данные введены неверно");
            }
        }

        public String getResult()
        {
            return ("Ответ: " + sum);
        }
    }
}
