using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number10
    {
        int[,] ints;
        int sizeX;
        int sizeY;

        public Number10(int[,] ints, int y, int x)
        {
            this.ints = ints;
            sizeX = x;
            sizeY = y;
            removeElements();
        }

        void removeElements()
        {
            int minNumb = ints[0, 0];
            int y = 0;
            int x = 0;
            for (int i = 0; i < sizeY; i++)
            {
                for (int k = 0; k < sizeX; k++)
                {
                    if (Math.Abs(ints[i, k]) < minNumb)
                    {
                        minNumb = Math.Abs(ints[i, k]);
                        y = i;
                        x = k;
                    }
                }
            }
            for (int i = 0; i < sizeY; i++)
            {
                for (int k = 0; k < sizeX; k++)
                {
                    if (i == y || k == x)
                    {
                        ints[i, k] = 0;
                    }
                }
            }
        }
        
        public void getMassiv()
        {
            Console.WriteLine("Элементы успешно удалены");
            for (int i = 0; i < sizeY; i++)
            {
                for (int k = 0; k < sizeX; k++)
                {
                    Console.Write(ints[i, k] + " ");
                }
                Console.WriteLine();
            }
        }        
    }
}
