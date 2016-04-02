using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdminProj
{
    class Products
    {
        public static Products selectedProduct;
        String nameProduct;
        int id, purchase, sale, stock, income;
        public static List<Products> products;

        public Products(int id, String name, int purch, int sale, int stock)
        {
            this.id = id;
            this.nameProduct = name;
            this.purchase = purch;
            this.sale = sale;
            this.stock = stock;
            income = sale - purchase;
        }

        public String getName
        {
            get { return nameProduct; }
        }
        public int Id { get { return id; } }
        public int getPurch
        {
            get { return purchase; }
        }
        public int getSale
        {
            get { return sale; }
        }
        public int getStock
        {
            get { return stock; }
        }
        public int getIncome
        {
            get { return income; }
        }

        public static List<Products> LoadMySqlListProducts()
        {
            products = new List<Products>();

            MySqlCommand command = new MySqlCommand(); ;
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=root;Password=30051996Ad;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "SELECT * FROM allProducts;";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products(Convert.ToInt32(reader["idProduct"]), Convert.ToString(reader["nameProduct"]), Convert.ToInt32(reader["purchase"]),
                        Convert.ToInt32(reader["salePrice"]), Convert.ToInt32(reader["stock"])));
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

        public static void changeInSQL(string commandStr)
        {
            MySqlCommand command = new MySqlCommand(); ;
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=root;Password=30051996Ad;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = commandStr;
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
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
        }
    }
}
