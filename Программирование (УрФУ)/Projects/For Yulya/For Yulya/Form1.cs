using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Yulya
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
           }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += textBox1.Text;
            label1.Text += " ";
            textBox1.Text = "";
            string str = label1.Text;
            string[] sample = str.Split(' ');
            string tmp;

            for (int i = 0; i < sample.Length; i++)
            {
                for (int j = sample.Length - 1; j > i; j--)
                {
                    if (sample[j - 1].Length < sample[j].Length)
                    {
                        tmp = sample[j - 1];
                        sample[j - 1] = sample[j];
                        sample[j] = tmp;
                    }
                }
            }
            label2.Text = Convert.ToString(sample);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        internal void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button1_Click(this, null); }
        }

        
    }
}
