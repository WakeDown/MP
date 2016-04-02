using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//INSERT INTO `products`.`clients` (`clientName`, `telephone`, `web`, `adress`, `countOrders`, `password`) VALUES ('Юля', '8-922-22-22-096', 'yandex.ru', 'Мира 33', '0', 'qwerty');

namespace ClientIProj
{
    public partial class RegClient : Form
    {
        public RegClient()
        {
            InitializeComponent();
        }

        private void RegClient_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 &&
                textBox2.Text.Length > 0 &&
                textBox3.Text.Length > 0 &&
                textBox4.Text.Length > 0 &&
                textBox5.Text.Length > 0)
            {
                int check = 1;
                foreach (Clients client in Clients.getData())
                {
                    if (textBox1.Text == client.Login)
                    {
                        check = 0;
                        string message =
        "Извините, но введеный логин уже занят. Введите, пожалуйста, другой.";
                        string caption = "Ошибка";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Warning);
                    }
                }
                if (check == 1)
                {
                    registring();
                    Close();

                }
            }
            else
            {
                string message =
        "Проверьте, что все поля заполнены.";
                string caption = "Ошибка";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
            }
        }

        private void registring()
        {
            MySqlCommand command = new MySqlCommand();
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=myuser;Password=123;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "INSERT INTO `products`.`clients` (`clientName`, `telephone`, `web`, `adress`, `countOrders`, `password`) VALUES ('" +
                textBox1.Text + "', '" + textBox4.Text +
                "', '" + textBox5.Text + "', '" + textBox3.Text +"', '0', '" + textBox2.Text + "');";
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
