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
    public partial class FGame : Form
    {
        Random rand = new Random();
        int durationMusic = Victorina.musicDuration;
        public FGame()
        {
            InitializeComponent();
        }
/// ///////////////////////////////////////////////////////////

        void MakeMusic()
        {
            durationMusic = Victorina.musicDuration;
            int n = rand.Next(Victorina.list.Count);
            WMP.URL = Victorina.list[n];
            WMP.Ctlcontrols.play();
            Victorina.list.RemoveAt(n);
            lbMusicCount.Text = Victorina.list.Count.ToString();
        }

/// ///////////////////////////////////////////////////

        private void butNext_Click(object sender, EventArgs e)
        {
            if (Victorina.list.Count == 0) GameEnd();
            else
            {
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                timer1.Stop();
                timer1.Start();
                MakeMusic();
            }

        }

/// ///////////////////////////////////////////////////////

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }
/// //////////////////////////////////////////////////////////////////
        private void FGame_Load(object sender, EventArgs e)
        {
            
            lbMusicCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.musicDuration;
        }
/// ////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            GameCont();
        }
/// ///////////////////////////////////////////////////////////////////
        void GameEnd()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

/// ////////////////////////////////////////////////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            durationMusic--;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GameEnd();
                return;
            }
            if (durationMusic == 0) GamePause();
        }

/// /////////////////////////////////////////////////////////////////////////

        private void butPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }
/// ///////////////////////////////////////////////////////////////////////////
        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
/// ///////////////////////////////////////////////////////////////////////
        void GameCont()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
/// ///////////////////////////////////////////////////////////////////////
        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                GamePause();
                FOtvet message = new FOtvet();
                message.lbMessage.Text = "Игрок 1";
                if (message.ShowDialog() == DialogResult.Yes)
                {
                    lbCount1.Text = Convert.ToString(Convert.ToInt32(lbCount1.Text)+1);
                }
            }
            if (e.KeyData == Keys.B)
            {
                GamePause();
                FOtvet message = new FOtvet();
                message.lbMessage.Text = "Игрок 2";
                if (message.ShowDialog() == DialogResult.Yes)
                {
                    lbCount12.Text = Convert.ToString(Convert.ToInt32(lbCount12.Text) + 1);
                }
            }
        }
/// ////////////////////////////////////////////////////////////////////////////////////////////////
        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.rondomstar)
            {
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rand.Next(0, (int)WMP.currentMedia.duration / 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
