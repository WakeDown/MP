using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_09._03._16
{
    class Number3
    {
        List<Client> clients;

        public Number3(List<Client> clients)
        {
            this.clients = clients;
        }

        public void getFiltrName(char c)
        {
            var filtrName =
                from client in clients
                where client.getName[0] <= c
                select client;
            foreach (Client client in filtrName)
            {
                Console.WriteLine(client.getName + " " + client.getTelephone.ToString() + " " + client.getEMail
                                    + client.getAdress + " " + client.getBugget.ToString());
            }
        }

        public void getFiltrName(string st)
        {
            var filtrName = from client in clients
                            select client; ;
            for (int i = 0; i < clients.Count; i++)
            {
                filtrName =
                    from client in clients
                    where client.getName[i] == st[i]
                    select client;
            }
            foreach (Client client in filtrName)
            {
                Console.WriteLine(client.getName + " " + client.getTelephone.ToString() + " " + client.getEMail
                                    + client.getAdress + " " + client.getBugget.ToString());
            }
        }

        public void getBugget(int first, int end)
        {
            var bugget =
                    from client in clients
                    where client.getBugget >=first
                    where client.getBugget <=end
                    select client;
            foreach (Client client in bugget)
            {
                Console.WriteLine(client.getName + " " + client.getTelephone.ToString() + " " + client.getEMail
                                    + client.getAdress + " " + client.getBugget.ToString());
            }
        }

        public void getDoubleSort()
        {
            var sort =
                    from client in clients
                    orderby client.getName
                    orderby client.getBugget
                    select client;
            foreach (Client client in sort)
            {
                Console.WriteLine(client.getName + " " + client.getTelephone.ToString() + " " + client.getEMail
                                    + client.getAdress + " " + client.getBugget.ToString());
            }
        }

        public void getDoubleFiltr(char c)
        {
            var filtr37 =
                from client in clients
                where client.getName[0] == c
                where (client.getBugget % 3) == 0 || (client.getBugget % 7) == 0
                select client;
            foreach (Client client in filtr37)
            {
                Console.WriteLine(client.getName + " " + client.getTelephone.ToString() + " " + client.getEMail
                    + client.getAdress + " " + client.getBugget.ToString());
            }
        }
    }
}
