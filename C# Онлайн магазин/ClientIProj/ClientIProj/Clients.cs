using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientIProj
{
    class Clients
    {
        private string login;
        private string password;
        private int id;
        private string telephone;
        private string adress;

        public static Clients user;
        
        public Clients(string login, string pass, int id, string telephone, string adress)
        {
            this.login = login;
            this.password = pass;
            this.id = id;
            this.telephone = telephone;
            this.adress = adress;
        }  

        public string Login { get { return login; } }
        public string Pass { get { return password; } }
        public int Id { get { return id; } }
        public string Telephone { get { return telephone; } }
        public string Adress { get { return adress; } }

        public static List<Clients> getData()
        {
            List<Clients> clients = new List<Clients>();

            MySqlCommand command = new MySqlCommand();
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=myuser;Password=123;database=products;";
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
                    clients.Add(new Clients(reader["clientName"].ToString(), reader["password"].ToString(), Convert.ToInt32(reader["idClient"]), reader["telephone"].ToString(), reader["adress"].ToString()));
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
