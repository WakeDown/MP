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
    public partial class EnterForm : Form
    {
        RegClient rc = new RegClient();
        public EnterForm()
        {
            InitializeComponent();
        }

        private void enterBut_Click(object sender, EventArgs e)
        {
            List<Clients> c = Clients.getData();

            try {
                Clients user = (from u in c
                                where u.Login == textBox1.Text
                                where u.Pass == textBox2.Text
                                select u).ElementAt(0);
                Program.setChek(1);
                Clients.user = new Clients(user.Login, user.Pass, user.Id, user.Telephone, user.Adress);
                Close();
            }catch(Exception ex)
            {
                
            }
            finally
            {
                string message =
        "Вы ввели неверный логин или пароль";
                string caption = "Неверный ввод данных";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rc.ShowDialog();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
