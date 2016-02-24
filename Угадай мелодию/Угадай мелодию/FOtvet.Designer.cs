namespace Угадай_мелодию
{
    partial class FOtvet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOtvet));
            this.lbMessage = new System.Windows.Forms.Label();
            this.butNo = new System.Windows.Forms.Button();
            this.butYes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Turquoise;
            this.lbMessage.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.Location = new System.Drawing.Point(12, 9);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(124, 36);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Message";
            // 
            // butNo
            // 
            this.butNo.BackColor = System.Drawing.Color.Firebrick;
            this.butNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.butNo.Location = new System.Drawing.Point(105, 117);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(87, 60);
            this.butNo.TabIndex = 1;
            this.butNo.Text = "Нет";
            this.butNo.UseVisualStyleBackColor = false;
            // 
            // butYes
            // 
            this.butYes.BackColor = System.Drawing.Color.Lime;
            this.butYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.butYes.Location = new System.Drawing.Point(12, 117);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(87, 60);
            this.butYes.TabIndex = 2;
            this.butYes.Text = "Да";
            this.butYes.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Turquoise;
            this.lbTime.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(162, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 36);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FOtvet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Угадай_мелодию.Properties.Resources.preview;
            this.ClientSize = new System.Drawing.Size(204, 189);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.butYes);
            this.Controls.Add(this.butNo);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FOtvet";
            this.Text = "Ответ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FOtvet_FormClosed);
            this.Load += new System.EventHandler(this.FOtvet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butNo;
        private System.Windows.Forms.Button butYes;
        public System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}