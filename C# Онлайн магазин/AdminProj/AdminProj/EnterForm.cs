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
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "30051996ad";

            if (textBox1.Text.Length > 0 && textBox1.Text == pass)
            {
                Program.check = 1;
                Close();
            }
            else
            {
                string message =
        "Введите пароль заново";
                string caption = "Неверный ввод данных";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}
