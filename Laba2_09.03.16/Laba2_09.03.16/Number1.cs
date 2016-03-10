using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number1
    {
        private string userString;
        private string firstLine;
        private string endLine;
        private Hashtable box;
        private int start, end;

        public Number1(string first)
        {
            this.firstLine = first;
            if (firstLine != null && firstLine[0] == '<' && firstLine[firstLine.Length - 1] == '>' && firstLine[1] != '/')
            {
                endLine = firstLine;
                endLine = endLine.Replace('<', '/');
                endLine = "<" + endLine;
                userString = "";
                start = end = 0;
                box = new Hashtable();
            }
            else Console.WriteLine("Ошиба ввода");
        }

        public void readtText()
        {
            string newString = " ";
            while(newString != endLine)
            {
                newString = Console.ReadLine();
                inspection(newString);
            }
            if (start != end)
            {
                Console.WriteLine("Ошибка ввода");
            }
            else Console.WriteLine(userString);
        }

        private void inspection(string stringtBox)
        {
            if (stringtBox != null && stringtBox[0] == '<' && stringtBox[stringtBox.Length - 1] == '>' && stringtBox[1] != '/')
            {
                string endBox = stringtBox;
                endBox = endBox.Replace('<', '/');
                endBox = "<" + endBox;
                box.Add(stringtBox, endBox);
                start++;
                return;
            }
            if (stringtBox != null && stringtBox[0] == '<' && stringtBox[stringtBox.Length - 1] == '>' && 
                stringtBox[1] == '/' && stringtBox != endLine)
            {
                string endBox = stringtBox;
                endBox = endBox.Remove(1, 1);
                if (box.ContainsKey(endBox))
                {
                    end++;
                }
                return;
            }
            else if(stringtBox != endLine) userString += stringtBox;
        }
    }
}
