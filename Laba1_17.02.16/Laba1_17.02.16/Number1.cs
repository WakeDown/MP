using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number1
    {
        String myStr;
        String result;

        public Number1(String mystr)
        {
            this.myStr = mystr;
            startNumber1();            
        }

        void startNumber1()
        {
            int countChar = 0;
            String[] newStr = myStr.Split(new char[] {' '});
            for (int i = 0; i < myStr.Length; i++)
                countChar++;
            result = myStr + " -" + countChar + " -" + newStr.Length;
        }

        public String getResult() {
            return result;
        }
    }
}
