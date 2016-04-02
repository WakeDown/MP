using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientIProj
{
    public partial class ClientsListsOrders : Form
    {

        private string file = "22";
        
        List<ClientsOrder> order = new List<ClientsOrder>();
        private string[] fileList;

        public ClientsListsOrders()
        {
            InitializeComponent();
        }

        private void выбратьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выбратьПапкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            if (fold.ShowDialog() == DialogResult.OK)
            {
                fileList = System.IO.Directory.GetFiles(fold.SelectedPath, "*.txt");
                listBox1.Items.Clear();
                listBox1.Items.AddRange(fileList);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox2.Items.Count > 0)
            {
                file = listBox1.SelectedItem.ToString();
                ClientsOrder.setOrder(file);
                MainForm mainForm = this.Owner as MainForm;
                mainForm.buttonGetShablon.Visible = true;
                Close();
                string message =
                    "Чтобы приминить выбранный шаблон, нажмите кнопку 'Приминить шаблон'.";
                string caption = "Вы выбрали шаблон";
                var result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                string message =
        "Вы не выбрали шаблон!";
                string caption = "Ошибка";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void ClientsListsOrders_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectItem = listBox1.SelectedItem.ToString();
                if (selectItem[selectItem.Length - 1] == 't')
                {
                    richTextBox1.Clear();
                    readSelectedFile(selectItem);
                    List<Product> prods = Product.loadData();
                    listBox2.Items.Clear();
                    foreach (ClientsOrder ord in order)
                    {
                        listBox2.Items.Add(prods.Where(x => x.Id == ord.idProd).ElementAt(0).NameProduct
                                           + ":  " + ord.countProd + " единиц.");
                    }
                    nameLab.Text = Path.GetFileName(selectItem);
                    dateLab.Text = File.GetCreationTime(selectItem).ToString();
                    autorLab.Text = new FileInfo(selectItem).GetAccessControl().GetOwner(typeof (NTAccount)).ToString();
                    sizeLab.Text = new FileInfo(selectItem).Length.ToString() + " Kb";
                    string[] filesStrings = File.ReadAllLines(selectItem);
                    foreach (string s in filesStrings)
                    {
                        richTextBox1.Text += (s + Environment.NewLine);
                    }
                }
            }catch(Exception ex) { } finally { }
        }

        private void readSelectedFile(string file)
        {
            order.Clear();
            var fileList = File.ReadAllLines(file)
                .Select(d =>
                {
                    string[] data = d.Split(':');
                    return new
                    {
                        id = Convert.ToInt32(data[0]),
                        count = Convert.ToInt32(data[1])
                    };
                });
            foreach (var data in fileList)
            {
                order.Add(new ClientsOrder(data.id, data.count));
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
