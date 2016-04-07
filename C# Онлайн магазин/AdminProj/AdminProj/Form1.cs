using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;

namespace AdminProj
{
    public partial class Form1 : Form
    {
        private List<Products> products;
        private List<Clients> clients;
        private List<Orders> orders;
        EditForm editForm = new EditForm();
        OrderInfoForm oif = new OrderInfoForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = Products.LoadMySqlListProducts();
            clients = Clients.LoadMySqlListClients();
            orders = Orders.loadSQLOrders();
            loadOrdersInList();
            loadClientsInList();
            loadProductsInList();
        }

        private void loadOrdersInList()
        {
            foreach (Orders order in orders)
            {
                string[] data =
                {
                    order.getId().ToString(), order.getName(), order.getAdress(), order.getDate(), order.status
                };
                listView3.Items.Add(new ListViewItem(data));
            }
        }

        private void loadProductsInList()
        {
            foreach (Products product in products)
            {
                string[] data = {product.Id.ToString(),
                    product.getName,
                    product.getPurch.ToString(),
                    product.getSale.ToString(),
                    product.getIncome.ToString(),
                    product.getStock.ToString()};
                listView1.Items.Add(new ListViewItem(data));
            }
        }

        private void loadClientsInList()
        {
            foreach (Clients client in clients)
            {
                string[] data =
                {
                    client.getId.ToString(),
                    client.getName, client.getTelephone(), client.getAdress(), client.getWeb()
                };
                listView2.Items.Add(new ListViewItem(data));
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteProd();
        }

        private void deleteProd()
        {
            string command = "";
            try
            {
                var prod = (from p in products
                    where p.Id == products[listView1.SelectedIndices[0]].Id
                    select p).ElementAt(0);
                command = "DELETE FROM `products`.`allproducts` WHERE `idProduct`=' " + prod.Id + "';";
            }catch(Exception ex) { } finally { }
            Products.changeInSQL(command);
            updateProdList();
        }

        private void updateProdList()
        {
            products = Products.LoadMySqlListProducts();
            listView1.Items.Clear();
            loadProductsInList();
        }

        private void updateClientsList()
        {
            clients = Clients.LoadMySqlListClients();
            listView2.Items.Clear();
            loadClientsInList();
        }

        private void updateOrderList()
        {
            orders = Orders.loadSQLOrders();
            listView3.Items.Clear();
            loadOrdersInList();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editProd();
        }

        private void editProd()
        {
            try
            {
                Products.selectedProduct = (from p in products
                    where p.Id == products[listView1.SelectedIndices[0]].Id
                    select p).ElementAt(0);
                EditForm.check = 1;
                editForm.ShowDialog();
            }catch(Exception ex) { }finally { }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            deleteProd();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            editProd();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            EditForm.check = 0;
            editForm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            updateProdList();
            updateClientsList();
            updateOrderList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateProdList();
            updateClientsList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateProdList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int purS = 0, saleS = 0, incS = 0, stockS = 0;
            int purF = int.MaxValue;
            int saleF = int.MaxValue;
            int incF = int.MaxValue;
            int stockF = int.MaxValue;
            try
            {
                if (int.TryParse(textBox2.Text, out purS) ||
                    int.TryParse(textBox4.Text, out saleS) ||
                    int.TryParse(textBox6.Text, out incS) ||
                    int.TryParse(textBox8.Text, out stockS) ||
                    int.TryParse(textBox3.Text, out purF) ||
                    int.TryParse(textBox5.Text, out saleF) ||
                    int.TryParse(textBox7.Text, out incF) ||
                    int.TryParse(textBox9.Text, out stockF))
                {
                    var newProds = Products.LoadMySqlListProducts().Where(x =>
                        x.getPurch >= purS && x.getPurch <= purF &&
                        x.getSale >= saleS && x.getSale <= saleF &&
                        x.getIncome >= incS && x.getIncome <= incF &&
                        x.getStock >= stockS && x.getStock <= stockF);
                    products = newProds.ToList();
                    listView1.Items.Clear();
                    loadProductsInList();
                }
                if (textBox1.Text.Length > 0)
                {
                    string s = textBox1.Text;
                    var newProds = products.Where(x =>
                        x.getName.Contains(s));
                    products = newProds.ToList();
                    listView1.Items.Clear();
                    loadProductsInList();
                }
            }catch(Exception ex) { } finally { }
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string s = toolStripTextBox1.Text;
                var newProds = Products.LoadMySqlListProducts().Where(x =>
                    x.getName.Contains(s));
                products = newProds.ToList();
                listView1.Items.Clear();
                loadProductsInList();
            }
            catch (Exception ex) { }
            finally { }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            updateClientsList();
            updateProdList();
            updateOrderList();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            deleteClient();
        }

        private void deleteClient()
        {
            try
            {
                var client = (from c in clients
                    where c.getId == clients[listView2.SelectedIndices[0]].getId
                    select c).ElementAt(0);
                string command = "DELETE FROM `products`.`clients` WHERE `idClient`=' " + client.getId + "';";
                Products.changeInSQL(command);
                updateClientsList();
            }catch(Exception ex) { }finally { }
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string s = toolStripTextBox2.Text;
                var newProds = Clients.LoadMySqlListClients().Where(x =>
                    x.getName.Contains(s));
                clients = newProds.ToList();
                listView2.Items.Clear();
                loadClientsInList();
            }
            catch (Exception ex) { }
            finally { }
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            deleteClient();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            updateOrderList();
            updateProdList();
            updateClientsList();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            deleteOrder();
            updateOrderList();
        }

        private void deleteOrder()
        {
            try
            {
                var order = (from o in orders
                    where o.getId() == orders[listView3.SelectedIndices[0]].getId()
                    select o).ElementAt(0);
                string command = "DELETE FROM `products`.`orders` WHERE `idOrder`=' " + order.getId() + "';";
                Products.changeInSQL(command);
                updateClientsList();
            }catch(Exception ex) { }finally { }
        }

        private void getOrderInfo()
        {
            try
            {
                var order = (from o in orders
                             where o.Id == orders[listView3.SelectedIndices[0]].getId()
                             select o).ElementAt(0);
                Orders.order = order;
                oif.ShowDialog();
            }
            catch (Exception ex) { }
            finally { }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            getOrderInfo();
        }

        private void подробноToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getOrderInfo();
        }

        private void удалитьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            deleteOrder();
            updateOrderList();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            openWord();
        }

        private void openWord()
        {
            Word.Application wdApp = new Word.Application();
            wdApp.Visible = true;
            wdApp.Documents.Add();
            Word.Document docum = wdApp.Documents.get_Item(1);
            wdApp.Selection.Text = "\nСписок клиентов за\n" + DateTime.Now;
            var wdRange = docum.Range(0, 0);
            var wdTable = docum.Tables.Add(wdRange, clients.Count + 1, 5);  //строки, столбцы
            wdTable.Cell(1, 1).Range.Text = "id";
            wdTable.Cell(1, 2).Range.Text = "Логин";
            wdTable.Cell(1, 3).Range.Text = "Телефон";
            wdTable.Cell(1, 4).Range.Text = "Адрес";
            wdTable.Cell(1, 5).Range.Text = "Сайт";
            for (int i = 2; i < clients.Count + 2; i++)
            {
                wdTable.Cell(i, 1).Range.Text = clients[i - 2].getId.ToString();
                wdTable.Cell(i, 2).Range.Text = clients[i - 2].getName;
                wdTable.Cell(i, 3).Range.Text = clients[i - 2].getTelephone();
                wdTable.Cell(i, 4).Range.Text = clients[i - 2].getAdress();
                wdTable.Cell(i, 5).Range.Text = clients[i - 2].getWeb();
            }
            wdTable.set_Style("Таблица-сетка 4");
        }
    }
}
