using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClientIProj
{
    class ClientsOrder
    {
        public int idProd { get; set; }
        public int countProd { get; set; }

        public static List<ClientsOrder> loadOrder = new List<ClientsOrder>();

        public ClientsOrder(int id, int count)
        {
            this.idProd = id;
            this.countProd = count;
        }

        public static void setOrder(string file)
        {
            loadOrder = new List<ClientsOrder>();
            var fileList = File.ReadAllLines(file)
                .Select(d =>
                {
                    string[] data = d.Split(':');
                    return new
                    {
                        id = Convert.ToInt32(data[0]),
                        count = Convert.ToInt32(data[1])
                    };
                });
            foreach (var data in fileList)
            {
                loadOrder.Add(new ClientsOrder(data.id, data.count));
            }
        }
    }
}
