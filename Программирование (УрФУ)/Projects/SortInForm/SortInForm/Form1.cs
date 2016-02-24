using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SortInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Введено:";
            label3.Text = textBox1.Text;
            label3.Text += ". Продолжай в том же духе! ";
            int i = Convert.ToInt32(textBox1.Text);
            using (var writer = new StreamWriter("file1.txt", true))
            {
                writer.WriteLine(i);
            }


            List<string> lst = new List<string>();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"file1.txt"))
            {
                while (sr.Peek() > -1)
                {
                    lst.Add(sr.ReadLine());
                }
            }
            var lstOut = lst.Take(50).OrderBy(x => int.Parse(x.Split(' ')[0])).Concat(lst.Skip(50));
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"file1.txt", append: false))
            {
                foreach (string str in lstOut)
                {
                    sw.WriteLine(str);
                }
            }


            string text = System.IO.File.ReadAllText(@"file1.txt");
            label2.Text = text;
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button1_Click(this, null); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("file1.txt");
            if (file.Exists == true) //Если файл существует
            {
                file.Delete(); //Удаляем
            }
            label1.Text = "Пусто!(";
            label3.Text += "Давай! Вводи еще раз свои числа.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
