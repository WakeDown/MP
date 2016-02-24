using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Угадай_мелодию
{
    public partial class FOtvet : Form
    {
        int time = Victorina.gameDuration;
        public FOtvet()
        {
            InitializeComponent();
        }

        private void FOtvet_Load(object sender, EventArgs e)
        {
            time = Victorina.gameDuration;
            lbTime.Text = Convert.ToString(Victorina.gameDuration);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lbTime.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                //SoundPlayer sp = new SoundPlayer("");
                //sp.Play();
            }
        }

        private void FOtvet_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            
        }
    }
}
