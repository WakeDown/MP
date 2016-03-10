using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_17._02._16
{

    class Number11
    {
        String myChars;

        public Number11(int myString)
        {
            this.myChars = myString.ToString();
            changeSting();
        }

        private void changeSting()
        {
            if (myChars.Length < 4)
                while (myChars.Length != 4)
                    myChars = "0" + myChars;
        }

        public String intInString()
        {
            String result = null;

            switch (myChars[0])
            {
                case '1': result += "одна тысяча "; break;
                case '2': result += "две тысячи "; break;
                case '3': result += "три тысячи "; break;
                case '4': result += "четыре тысячи "; break;
                case '5': result += "пять тысяч "; break;
                case '6': result += "шесть тысяч "; break;
                case '7': result += "семь тысяч "; break;
                case '8': result += "восемь тысяч "; break;
                case '9': result += "девять тысяч "; break;
                default: break;
            }

            switch (myChars[1])
            {
                case '1': result += "сто "; break;
                case '2': result += "двести "; break;
                case '3': result += "триста "; break;
                case '4': result += "четыреста "; break;
                case '5': result += "пятьсот "; break;
                case '6': result += "шестьсот "; break;
                case '7': result += "семьсот "; break;
                case '8': result += "восемьсот "; break;
                case '9': result += "девятьсот "; break;
                default: break;
            }

            switch (myChars[2])
            {
                case '1': result += someNumber(); return result;
                case '2': result += "двадцать "; break;
                case '3': result += "тридцать "; break;
                case '4': result += "сорок "; break;
                case '5': result += "пятьдесят "; break;
                case '6': result += "шестьдесят "; break;
                case '7': result += "семьдесят "; break;
                case '8': result += "восемьдесят "; break;
                case '9': result += "девяносто "; break;
                default: break;
            }

            switch (myChars[3])
            {
                case '1': result += "один "; break;
                case '2': result += "два "; break;
                case '3': result += "три "; break;
                case '4': result += "четыре "; break;
                case '5': result += "пять "; break;
                case '6': result += "шесть "; break;
                case '7': result += "семь "; break;
                case '8': result += "восемь "; break;
                case '9': result += "девять "; break;
                default: break;
            }

            return result;
        }

        private string someNumber()
        {
            switch (myChars[3])
            {
                case '1': return "одиннадцать";
                case '2': return "двенадцать";
                case '3': return "тринадцать";
                case '4': return "четырнадцать";
                case '5': return "пятнадцать";
                case '6': return "шестнадцать";
                case '7': return "семнадцать";
                case '8': return "восемнадцать";
                case '9': return "девятнадцать";
                default: return "десять";
            }
        }
    }
}
