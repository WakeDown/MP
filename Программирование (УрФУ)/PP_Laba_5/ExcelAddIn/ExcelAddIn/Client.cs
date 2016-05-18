using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAddIn
{
    class Client
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int OrderCount { get; set; }

        public Client(string name, int money, int orderCount)
        {
            Name = name;
            Money = money;
            OrderCount = orderCount;
        }
    }
}
