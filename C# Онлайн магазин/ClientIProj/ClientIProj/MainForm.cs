using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientIProj
{
    public partial class MainForm : Form
    {
        private List<Product> products;
        private List<ClientsOrder> order = new List<ClientsOrder>();
        private int summa;
        private ClientsListsOrders clo = new ClientsListsOrders();
        private BasketForm bf = new BasketForm();
        private  OrderHisrory oh = new OrderHisrory();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UsersAvatar.UserImage = null;
            loadAvatar();
            initUserParam();
            products = Product.loadData();
            foreach(var prod in products)
            {
                string[] prods = new[] {prod.NameProduct, prod.Prise.ToString(), prod.Stock.ToString()};
                listView1.Items.Add(new ListViewItem(prods));
            }
            summa = 0;      
        }

        private void initUserParam()
        {
            if (UsersAvatar.UserImage != null)
            pictureBox2.Image = UsersAvatar.UserImage;
            countLab.Text = OrdersForHistory.getUserOrders().Count.ToString();
        }

        private void loadAvatar()
        {
            string file = Clients.user.Login + ".avatar";
            if (File.Exists(file))
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    UsersAvatar.UserImage = (Image) formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int i = 0;
                if (textBox4.Text.Length != 0 && int.TryParse(textBox4.Text, out i))
                {
                    int sum = i*products[listView1.SelectedIndices[0]].Prise;
                    sumProdLabel.Text = sum.ToString();
                }
            }catch(Exception ex) { }finally { }
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                if (int.TryParse(textBox4.Text, out i))
                {
                    if (int.Parse(textBox4.Text) <= products[listView1.SelectedIndices[0]].Stock)
                    {

                        order.Add(new ClientsOrder(products[listView1.SelectedIndices[0]].Id, i));
                        listBox2.Items.Add(products[listView1.SelectedIndices[0]].NameProduct + ": " + textBox4.Text +
                                           " ед.; " + sumProdLabel.Text +
                                           " рублей");
                        summa += Convert.ToInt32(sumProdLabel.Text);
                        sumLabel.Text = summa.ToString();
                        textBox4.Text = "";
                        sumProdLabel.Text = "0";
                        products[listView1.SelectedIndices[0]].Stock -= i;
                        listView1.Items.Clear();
                        foreach (var prod in products)
                        {
                            string[] prods = new[] {prod.NameProduct, prod.Prise.ToString(), prod.Stock.ToString()};
                            listView1.Items.Add(new ListViewItem(prods));
                        }
                    }
                    else
                    {
                        string message =
                            "Введенное вами количество больше, чем есть в наличии.";
                        string caption = "Внимание";
                        var result = MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }catch(Exception ex) { } finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = -1;
                index = listBox2.SelectedIndex;
                if (index > -1)
                {
                    listBox2.Items.RemoveAt(index);
                    var delProd = (from p in products
                        where p.Id == order[index].idProd
                        select p).ElementAt(0);
                    products.Where(x => x.Id == order[index].idProd).ElementAt(0).Stock += order[index].countProd;
                    summa -= delProd.Prise*order[index].countProd;
                    order.RemoveAt(index);
                    sumLabel.Text = summa.ToString();
                }
            }catch(Exception ex) { }finally { }
        }

        private void сохранитьШаблонКарзиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (order.Count > 0)
            {
                foreach (var ord in order)
                {
                    richTextBox1.Text += (ord.idProd.ToString() + ":" + ord.countProd.ToString() + Environment.NewLine);
                }
               
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.txt";
                saveFile1.Filter = "txt Files|*.txt";
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   saveFile1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);

                }
            }
        }

        private void открытьШаблонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clo.Owner = this;
            clo.ShowDialog();
        }

        public void getFile()
        {
            clearShop();
            order = ClientsOrder.loadOrder;
            foreach (var ord in order)
            {
                int s = products.Where(x => x.Id == ord.idProd).ElementAt(0).Prise * ord.countProd;
                listBox2.Items.Add(products.Where(x => x.Id == ord.idProd).ElementAt(0).NameProduct + ": " +
                    ord.countProd + " ед.;" 
                    + s + " рублей");
                summa += s;
            }
            sumLabel.Text = summa.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientsOrder.loadOrder.Count > 0) getFile();
            else
            {
                string message =
        "Для выбора шаблона перейдите через меню в пункт 'Выбрать шаблон'";
                string caption = "Вы не выбрали шаблон";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearShop();
        }

        private void clearShop()
        {
            listBox2.Items.Clear();
            order.Clear();
            updata();
            summa = 0;
            sumLabel.Text = "0";
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (order.Count > 0)
            {
                ClientsOrder.loadOrder = order;
                bf.Owner = this;
                bf.ShowDialog();
            }
            else
            {
                string message =
        "Вы не добавили продукцию, чтобы перейти к оформлению заказа";
                string caption = "Пустая карзина";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                var navigateProd = products.Where(x => x.NameProduct.Contains(textBox1.Text));
                listView1.Items.Clear();
                foreach (var np in navigateProd)
                {
                    string[] prods = new[] {np.NameProduct, np.Prise.ToString(), np.Stock.ToString()};
                    listView1.Items.Add(new ListViewItem(prods));
                }
            }
        }

        private void navigateBut_Click(object sender, EventArgs e)
        {
            int first = 0;
            int end = int.MaxValue;
            if (int.TryParse(textBox2.Text, out  first) || int.TryParse(textBox3.Text, out end))
            {
                    if (first <= end)
                    {
                        var navigateProd = from np in products
                            where np.Prise >= first && np.Prise <= end
                            select np;
                        listView1.Items.Clear();
                        foreach (var np in navigateProd)
                        {
                            string[] prods = new[] { np.NameProduct, np.Prise.ToString(), np.Stock.ToString() };
                            listView1.Items.Add(new ListViewItem(prods));
                        }
                    }
            }
        }

        private void firstBut_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var prod in products)
            {
                string[] prods = new[] { prod.NameProduct, prod.Prise.ToString(), prod.Stock.ToString() };
                listView1.Items.Add(new ListViewItem(prods));
            }
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void updata()
        {
            listView1.Items.Clear();
            products = Product.loadData();
            foreach (var prod in products)
            {
                string[] prods = new[] { prod.NameProduct, prod.Prise.ToString(), prod.Stock.ToString() };
                listView1.Items.Add(new ListViewItem(prods));
            }
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oh.Owner = this;
            oh.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectProd = products.Where(sp => sp.NameProduct == listView1.SelectedItems[0].Text).ElementAt(0);
                label4.Text = selectProd.NameProduct;
            }
            catch (Exception ex) { }
            finally { }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
