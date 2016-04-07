using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ClientIProj
{
    public partial class OrderHisrory : Form
    {
        public OrderHisrory()
        {
            InitializeComponent();
        }

        private List<OrdersForHistory> orders;
        private Clients user = Clients.user;

        private void OrderHisrory_Load(object sender, EventArgs e)
        {
            if (UsersAvatar.UserImage != null)
            pictureBox1.Image = UsersAvatar.UserImage;
            dataGridView1.Rows.Clear();
            orders = OrdersForHistory.getUserOrders();
            initDataUser();
            foreach (OrdersForHistory order in orders)
            {
                string[] data = {order.products, order.date, order.price.ToString(), order.status};
                dataGridView1.Rows.Add(data);
            }
            
        }

        private void initDataUser()
        {
            toolStripLabel1.Text = user.Login;
            idLab.Text = user.Id.ToString();
            loginLab.Text = user.Login;
            pasLab.Text = "";
            for (int i = 0; i < user.Pass.Length; i++)  pasLab.Text += '*';
            telLab.Text = user.Telephone;
            webLab.Text = user.Adress;
            toolStripLabel2.Text ="Всего: " + orders.Count + " заказов.";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сменитьКартинкуПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAvatar();
        }

        private void changeAvatar()
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Картинки(*.JPG;*.GIF)|*.JPG;*.GIF" + "|Все файлы (*.*)|*.* ";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                UsersAvatar.UserImage = Image.FromFile(myDialog.FileName);
                pictureBox1.Image = UsersAvatar.UserImage;
                saveAvatarLocal();
                MainForm mainForm = this.Owner as MainForm;
                mainForm.pictureBox2.Image = UsersAvatar.UserImage;
            };
        }

        private void saveAvatarLocal()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(user.Login + ".avatar",
               FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, UsersAvatar.UserImage);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Word.Application wdApp = new Word.Application();
            wdApp.Visible = true;
            wdApp.Documents.Add();
            Word.Document docum = wdApp.Documents.get_Item(1);
            var wdRange = docum.Range(0, 0);
            var wdTable = docum.Tables.Add(wdRange, orders.Count + 1, 4);  //строки, столбцы
            wdTable.Cell(1, 1).Range.Text = "Продукция";
            wdTable.Cell(1, 2).Range.Text = "Дата";
            wdTable.Cell(1, 3).Range.Text = "Стоимость";
            wdTable.Cell(1, 4).Range.Text = "Статус";
            for (int i = 2; i < orders.Count + 2; i++)
            {
                wdTable.Cell(i, 1).Range.Text = orders[i - 2].products;
                wdTable.Cell(i, 2).Range.Text = orders[i - 2].date;
                wdTable.Cell(i, 3).Range.Text = orders[i - 2].price.ToString();
                wdTable.Cell(i, 4).Range.Text = orders[i - 2].status;
            }
            wdTable.set_Style("Таблица-сетка 4");
        }
    }
}
