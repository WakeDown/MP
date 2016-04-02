using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientIProj
{
    class Product
    {
        private int prise;
        private string nameProd;
        private int stock;
        private int id;

        public Product(int id, string name, int prise, int stock)
        {
            this.id = id;
            this.nameProd = name;
            this.prise = prise;
            this.stock = stock;
        }

        public int Id { get { return id; } }
        public string NameProduct { get { return nameProd; } }
        public int Prise { get { return prise; } }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public static List<Product> loadData()
        {
            List<Product> products = new List<Product>();

            MySqlCommand command = new MySqlCommand(); ;
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=myuser;Password=123;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "SELECT * FROM allproducts;";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(Convert.ToInt32(reader["idProduct"]), 
                        reader["nameProduct"].ToString(), 
                        Convert.ToInt32(reader["salePrice"]), 
                        Convert.ToInt32(reader["stock"])));
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

            return products;
        }
    }
}
