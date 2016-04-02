using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdminProj
{
    class Clients
    {
        private int id;
        private string clientName;
        private string telephoneNumber;
        private string web;
        private string adress;

        public Clients(int id, string clientName, string telephoneNumber, string web, string adress)
        {
            this.id = id;
            this.clientName = clientName;
            this.telephoneNumber = telephoneNumber;
            this.web = web;
            this.adress = adress;
        }

        public int getId
        {
            get { return id; }
        }

        public String getName
        {
            get { return clientName; }
        }

        public string getTelephone()
        {
            return telephoneNumber;
        }

        public string getWeb()
        {
            return web;
        }

        public string getAdress()
        {
            return adress;
        }

        public static List<Clients> LoadMySqlListClients()
        {
            List<Clients> clients = new List<Clients>();

            MySqlCommand command = new MySqlCommand(); ;
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=root;Password=30051996Ad;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "SELECT * FROM clients;";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                        clients.Add(new Clients(Convert.ToInt32(reader["idClient"]), reader["clientName"].ToString(),
                            reader["telephone"].ToString(), reader["web"].ToString(),
                            reader["adress"].ToString()));
                    
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }

            return clients;
        }
    }
}
