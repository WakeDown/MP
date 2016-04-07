using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AdminProj
{
    public partial class OrderInfoForm : Form
    {
        private Orders order;
        public OrderInfoForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openExcel();
        }

        private void openExcel()
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            excel.SheetsInNewWorkbook = 1;
            excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet exWrkSht = excel.Workbooks[1].Worksheets.get_Item(1);
            exWrkSht.get_Range("A1").Value = "Заказ " + order.Id;

            int index = 2;
            string[] data = order.Code.Split(';');
            foreach (var d in data)
            {
                try
                {
                    string[] info = d.Split('-');
                    string i = info[0];
                    var s = (from p in Products.products
                             where p.Id.ToString() == i
                             select p).ElementAt(0);
                    info[0] = s.getName;
                    string B = "B" + index;
                    string C = "C" + index;
                    exWrkSht.get_Range(B).Value = info[0];
                    exWrkSht.get_Range(C).Value = info[1];
                    index++;
                }
                catch (Exception ex) { }
                finally
                {

                }
            }
        }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            initTable();
        }

        private void initTable()
        {
            order = Orders.order;
            string[] data = order.Code.Split(';');
            foreach (var d in data)
            {
                try
                {
                    string[] info = d.Split('-');
                    string i = info[0];
                    var s = (from p in Products.products
                             where p.Id.ToString() == i
                             select p).ElementAt(0);
                    info[0] = s.getName;
                    dataGridView1.Rows.Add(info);
                    toolStripLabel2.Text = order.status;
                }
                catch (Exception ex) { }
                finally
                {

                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string command = "UPDATE `products`.`orders` SET `status`='" + "Отменено" + "' WHERE `idOrder`=' +" + order.Id +" +';";
            Products.changeInSQL(command);
            toolStripLabel2.Text = "Отменено";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string command = "UPDATE `products`.`orders` SET `status`='" + "В ожидании" + "' WHERE `idOrder`=' +" + order.Id + " +';";
            Products.changeInSQL(command);
            toolStripLabel2.Text = "В ожидании";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string command = "UPDATE `products`.`orders` SET `status`='" + "В пути" + "' WHERE `idOrder`=' +" + order.Id + " +';";
            Products.changeInSQL(command);
            toolStripLabel2.Text = "В пути";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string command = "UPDATE `products`.`orders` SET `status`='" + "Выполнено" + "' WHERE `idOrder`=' +" + order.Id + " +';";
            Products.changeInSQL(command);
            toolStripLabel2.Text = "Выполнено";
        }
    }
}
