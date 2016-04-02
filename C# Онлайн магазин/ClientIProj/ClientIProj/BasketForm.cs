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

namespace ClientIProj
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }
        private int itog = 0;
        private void BasketForm_Load(object sender, EventArgs e)
        {
            List<Product> prods = Product.loadData();
            foreach (var i in ClientsOrder.loadOrder)
            {
                var prod = (from p in prods
                            where p.Id == i.idProd
                            select p).ElementAt(0);
                int price = i.countProd * prod.Prise;
                string[] s = new string[] { prod.NameProduct, i.countProd.ToString(),  price.ToString()};
                listView1.Items.Add(new ListViewItem(s));
                itog += price;
            }
            label1.Text = "Итог: " + itog.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arhiv = "";
            DateTime dateNow = DateTime.Now;
            string date = dateNow.Year.ToString() + "-" + dateNow.Month.ToString() + "-" + dateNow.Day.ToString(); 
            foreach (var i in ClientsOrder.loadOrder)
            {
                arhiv += (i.idProd + "-" + i.countProd + ";");
            }
            MySqlCommand command = new MySqlCommand();
            string connectionString, commandString;
            connectionString = "Data source=localhost;UserId=myuser;Password=123;database=products;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            commandString = "INSERT INTO `products`.`orders` (`clientName`, `date`, `adress`, `arhiv`) VALUES ('"+ Clients.user.Login
                + "', '" + date + "', '" + Clients.user.Adress + "', '" + arhiv + "');";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                MainForm mainForm = this.Owner as MainForm;
                mainForm.countLab.Text = OrdersForHistory.getUserOrders().Count.ToString();
                reader.Close();
                string message =
        "Ваш заказ был успешно отправлен. Спасибо, что пользуютесь нашими услугами.";
                string caption = "Заказ отправлен";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            Close();
        }
    }
}
