using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminProj
{
    public partial class OrderInfoForm : Form
    {
        public OrderInfoForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            initTable();
        }

        private void initTable()
        {
            Orders order = Orders.order;
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
                }
                catch (Exception ex) { }
                finally
                {

                }
            }
        }
    }
}
