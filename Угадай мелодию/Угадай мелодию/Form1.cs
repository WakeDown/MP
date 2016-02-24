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
    public partial class FMain : Form
    {
        FOptions Opt = new FOptions();
        FGame Game = new FGame();
        public FMain()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOptions_Click(object sender, EventArgs e)
        {
            Opt.ShowDialog();
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            Game.ShowDialog();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }
    }
}
