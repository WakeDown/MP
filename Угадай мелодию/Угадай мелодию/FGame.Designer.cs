namespace Угадай_мелодию
{
    partial class FGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.butNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCount1 = new System.Windows.Forms.Label();
            this.lbCount12 = new System.Windows.Forms.Label();
            this.butPause = new System.Windows.Forms.Button();
            this.butPlay = new System.Windows.Forms.Button();
            this.lbMusicCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(269, 331);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 0;
            this.WMP.UseWaitCursor = true;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(175, 278);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(118, 39);
            this.butNext.TabIndex = 1;
            this.butNext.Text = "Поехали!";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.UseWaitCursor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок 2";
            this.label2.UseWaitCursor = true;
            // 
            // lbCount1
            // 
            this.lbCount1.AutoSize = true;
            this.lbCount1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount1.Location = new System.Drawing.Point(75, 50);
            this.lbCount1.Name = "lbCount1";
            this.lbCount1.Size = new System.Drawing.Size(35, 37);
            this.lbCount1.TabIndex = 4;
            this.lbCount1.Text = "0";
            this.lbCount1.UseWaitCursor = true;
            // 
            // lbCount12
            // 
            this.lbCount12.AutoSize = true;
            this.lbCount12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbCount12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount12.Location = new System.Drawing.Point(75, 219);
            this.lbCount12.Name = "lbCount12";
            this.lbCount12.Size = new System.Drawing.Size(35, 37);
            this.lbCount12.TabIndex = 5;
            this.lbCount12.Text = "0";
            this.lbCount12.UseWaitCursor = true;
            // 
            // butPause
            // 
            this.butPause.Location = new System.Drawing.Point(311, 278);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(118, 39);
            this.butPause.TabIndex = 6;
            this.butPause.Text = "Пауза";
            this.butPause.UseVisualStyleBackColor = true;
            this.butPause.UseWaitCursor = true;
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // butPlay
            // 
            this.butPlay.Location = new System.Drawing.Point(450, 278);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(118, 39);
            this.butPlay.TabIndex = 7;
            this.butPlay.Text = "Продолжить";
            this.butPlay.UseVisualStyleBackColor = true;
            this.butPlay.UseWaitCursor = true;
            this.butPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbMusicCount
            // 
            this.lbMusicCount.AutoSize = true;
            this.lbMusicCount.Location = new System.Drawing.Point(555, 12);
            this.lbMusicCount.Name = "lbMusicCount";
            this.lbMusicCount.Size = new System.Drawing.Size(13, 13);
            this.lbMusicCount.TabIndex = 8;
            this.lbMusicCount.Text = "0";
            this.lbMusicCount.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(175, 323);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Value = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Угадай_мелодию.Properties.Resources._01;
            this.pictureBox1.Location = new System.Drawing.Point(175, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 346);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Угадай_мелодию.Properties.Resources.preview;
            this.ClientSize = new System.Drawing.Size(594, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbMusicCount);
            this.Controls.Add(this.butPlay);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.lbCount12);
            this.Controls.Add(this.lbCount1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FGame";
            this.Text = "Игра";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGame_FormClosed);
            this.Load += new System.EventHandler(this.FGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCount1;
        private System.Windows.Forms.Label lbCount12;
        private System.Windows.Forms.Button butPause;
        private System.Windows.Forms.Button butPlay;
        private System.Windows.Forms.Label lbMusicCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}