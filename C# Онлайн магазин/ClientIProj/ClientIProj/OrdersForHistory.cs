using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClientIProj
{
    class OrdersForHistory
    {
        public string products { get; set; }
        public string date { get; set; }
        public int price { get; set; }

        public OrdersForHistory(string p, string d, int pr)
        {
            products = p;
            date = d;
            price = pr;
        }

        public static List<OrdersForHistory> getUserOrders()
        {
            List<OrdersForHistory> orders = new List<OrdersForHistory>();

            MySqlCommand command = new MySqlCommand();
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=myuser;Password=123;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "SELECT * FROM products.orders where clientName = '" + Clients.user.Login + "';";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] order = reader["arhiv"].ToString().Split(';');
                    string prods = "";
                    int pr = 0;
                    foreach (string s in order)
                    {
                        string[] data = s.Split('-');
                        try
                        {
                            var ps = (from p in Product.loadData()
                                where p.Id == Convert.ToInt32(data[0])
                                select p).ElementAt(0);
                            prods += (ps.NameProduct + "; ");
                            pr += (ps.Prise*Convert.ToInt32(data[1]));
                        }catch(Exception ex) { } finally { }
                    }
                    orders.Add(new OrdersForHistory(prods, reader["date"].ToString(), pr));
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
