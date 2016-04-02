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
    public partial class EditForm : Form
    {
        private Products product;
        public static int check = 0;
        public EditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            if (check == 1) editWork();
        }

        private void editWork()
        {
            product = Products.selectedProduct;
            textBox1.Text = product.getName;
            textBox2.Text = product.getPurch.ToString();
            textBox3.Text = product.getSale.ToString();
            textBox4.Text = product.getStock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1: editProd(); break;
                case 0: addProd(); break;
            }
            Close();
        }

        private void editProd()
        {
            string command = "UPDATE `products`.`allproducts` SET `nameProduct`='" + textBox1.Text +
                                     "', `purchase`='" + textBox2.Text +
                                     "', `salePrice`='" + textBox3.Text +
                                     "', `stock`='" + textBox4.Text +
                                     "' WHERE `idProduct`='" + product.Id + "';";
            Products.changeInSQL(command);
        }

        private void addProd()
        {
            string command = "INSERT INTO `products`.`allproducts` (`nameProduct`, `purchase`, `salePrice`, `stock`) VALUES('"
                    + textBox1.Text + "', '" + textBox2.Text
                    + "', '" + textBox3.Text + "', '" + textBox4.Text + "');";
            Products.changeInSQL(command);
        }
    }
}
