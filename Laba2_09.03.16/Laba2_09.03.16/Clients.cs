using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Client
    {
        private string name;
        private int telephone;
        private string adress;
        private string eMail;
        private int bugget;

        public Client(string name, int telephone, string adress, string eMail, int bugget)
        {
            this.name = name;
            this.telephone = telephone;
            this.adress = adress;
            this.eMail = eMail;
            this.bugget = bugget;
        }

        public string getName { get { return name; } }

        public int getTelephone { get { return telephone; } }

        public string getAdress { get { return adress; } }

        public string getEMail { get { return eMail; } }

        public int getBugget { get { return bugget; } }

        public static List<Client> getList()
        {
            List<Client> clients = new List<Client>();

            clients.Add(new Client("MRDG", 21611103, "Mira 21", "mrdg@gmail.com", 130000));
            clients.Add(new Client("MCD", 2167403, "Mira 19", "mdc@gmail.com", 100000));
            clients.Add(new Client("FF", 3728331, "Mira 18", "ff@gmail.com", 150000));
            clients.Add(new Client("ABC", 3101010, "Mira 17", "abc@gmail.com", 300000));

            return clients;
        }
    }
}
