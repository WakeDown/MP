using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdminProj
{
    class Orders
    {
        private int id;
        private string clientName;
        private string date;
        private string code;
        private string adress;
        public string status { get; set; }

        public static Orders order;

        public Orders(int id, string clientName, string date, string code, string adress, string st)
        {
            this.id = id;
            this.clientName = clientName;
            this.date = date;
            this.code = code;
            this.adress = adress;
            status = st;
        }

        public int Id { get { return id; } }

        public string Code { get { return code; } }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return clientName;
        }

        public string getDate()
        {
            return date;
        }

        public string getCode()
        {
            return code;
        }

        public string getAdress()
        {
            return adress;
        }

        public static List<Orders> loadSQLOrders()
        {
            List<Orders> orders = new List<Orders>();
            MySqlCommand command = new MySqlCommand(); ;
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=root;Password=30051996Ad;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "SELECT * FROM orders;";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Orders(Convert.ToInt32(reader["idOrder"]), reader["clientName"].ToString(),
                        reader["date"].ToString(), reader["arhiv"].ToString(),
                        reader["adress"].ToString(), reader["status"].ToString()));
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
            return orders;
        }
    }
}
