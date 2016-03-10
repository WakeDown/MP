using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угадай_мелодию
{
    public partial class FOptions : Form
    {
        public FOptions()
        {
            InitializeComponent();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = checkObr.Checked;
            Victorina.gameDuration = Convert.ToInt32(comGameDur.Text);
            Victorina.musicDuration = Convert.ToInt32(comMusicDur.Text);
            Victorina.rondomstar = checkRondom.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        void Set()
        {
            checkObr.Checked = Victorina.allDirectories;
            comGameDur.Text = Victorina.gameDuration.ToString();
            comMusicDur.Text = Victorina.musicDuration.ToString();
            checkRondom.Checked = Victorina.rondomstar;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void butDowload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            if (fold.ShowDialog() == DialogResult.OK)
            {
                string[] musiclist = System.IO.Directory.GetFiles(fold.SelectedPath, "*.mp3", checkObr.Checked? System.IO.SearchOption.AllDirectories:System.IO.SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fold.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musiclist);
                Victorina.list.Clear();
                Victorina.list.AddRange(musiclist);
            };
        }

        private void FOptions_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Victorina.list.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
