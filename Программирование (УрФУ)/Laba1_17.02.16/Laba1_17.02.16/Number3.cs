using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number3
    {
        int count;
        int startNum;
        int endNum;

        String result = null;

        public Number3(int count, int startNum, int endNum)
        {
            this.count = count;
            this.startNum = startNum;
            this.endNum = endNum + 1;
            initRandom();
        }

        void initRandom()
        {
            int[] ints = new int[count];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {                
                ints[i] = random.Next(startNum, endNum);
            }
            countTheSame(ints);
        }

        void countTheSame(int[] ints)
        {
            Array.Sort(ints);
            int countNum = 1;
            for (int i = 0; i < count - 1; i++)
            {
                if (ints[i] == ints[i + 1] && i != (count - 2)) countNum++;
                else {
                    if (ints[i] != endNum - 1)
                    {
                        result += (ints[i] + " - " + countNum + "\n");
                        countNum = 1;
                    }
                    else
                    {
                        countNum ++;
                        result += (ints[i] + " - " + countNum + "\n");                        
                    }
                }
            }
        }

        public String getResult() {
            return result;
        }
    }
}
