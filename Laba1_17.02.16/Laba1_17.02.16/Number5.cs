using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{
    class Number5
    {
        double sideA;
        double sideB;
        double sideC;
        double heightH;
        int angle;

        double s;

        public Number5 (double sideC, double heightH)
        {
            this.sideC = sideC;
            this.heightH = heightH;
            areaOnSideAndHeight();
        }

        void areaOnSideAndHeight()
        {
            s = (sideC * heightH) / 2;
        }

        public Number5(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            areaOnTreeSide();
        }

        void areaOnTreeSide()
        {
            double p = sideA + sideB + sideC;
            s = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public Number5(double sideA, double sideB, int angle)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.angle = angle;
            areaOnTwoSideAndAngle();
        }

        void areaOnTwoSideAndAngle()
        {
            s = (sideA * sideB * Math.Sin(angle));
        }

        public String getResult()
        {
            return ("Ответ:" + s);
        }
    }
}
