namespace Угадай_мелодию
{
    partial class FOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOptions));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butDowload = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.checkObr = new System.Windows.Forms.CheckBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkRondom = new System.Windows.Forms.CheckBox();
            this.comMusicDur = new System.Windows.Forms.ComboBox();
            this.comGameDur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(9, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 158);
            this.listBox1.TabIndex = 0;
            // 
            // butDowload
            // 
            this.butDowload.Location = new System.Drawing.Point(9, 185);
            this.butDowload.Name = "butDowload";
            this.butDowload.Size = new System.Drawing.Size(75, 23);
            this.butDowload.TabIndex = 1;
            this.butDowload.Text = "Загрузить";
            this.butDowload.UseVisualStyleBackColor = true;
            this.butDowload.Click += new System.EventHandler(this.butDowload_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(149, 185);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "Очистить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // checkObr
            // 
            this.checkObr.AutoSize = true;
            this.checkObr.Location = new System.Drawing.Point(230, 21);
            this.checkObr.Name = "checkObr";
            this.checkObr.Size = new System.Drawing.Size(81, 18);
            this.checkObr.TabIndex = 3;
            this.checkObr.Text = "Обработка";
            this.checkObr.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(335, 281);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(98, 41);
            this.butOk.TabIndex = 4;
            this.butOk.Text = "Сохранить";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(439, 281);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(98, 41);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkRondom);
            this.groupBox1.Controls.Add(this.comMusicDur);
            this.groupBox1.Controls.Add(this.comGameDur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.checkObr);
            this.groupBox1.Controls.Add(this.butDowload);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Продолжительность ответа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkRondom
            // 
            this.checkRondom.AutoSize = true;
            this.checkRondom.Location = new System.Drawing.Point(9, 214);
            this.checkRondom.Name = "checkRondom";
            this.checkRondom.Size = new System.Drawing.Size(116, 18);
            this.checkRondom.TabIndex = 4;
            this.checkRondom.Text = "Случайный старт";
            this.checkRondom.UseVisualStyleBackColor = true;
            // 
            // comMusicDur
            // 
            this.comMusicDur.FormattingEnabled = true;
            this.comMusicDur.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.comMusicDur.Location = new System.Drawing.Point(190, 253);
            this.comMusicDur.Name = "comMusicDur";
            this.comMusicDur.Size = new System.Drawing.Size(121, 22);
            this.comMusicDur.TabIndex = 3;
            // 
            // comGameDur
            // 
            this.comGameDur.FormattingEnabled = true;
            this.comGameDur.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "30",
            "60"});
            this.comGameDur.Location = new System.Drawing.Point(190, 279);
            this.comGameDur.Name = "comGameDur";
            this.comGameDur.Size = new System.Drawing.Size(121, 22);
            this.comGameDur.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // FOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Угадай_мелодию.Properties.Resources.preview;
            this.ClientSize = new System.Drawing.Size(540, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FOptions";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butDowload;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.CheckBox checkObr;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkRondom;
        private System.Windows.Forms.ComboBox comGameDur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comMusicDur;
        private System.Windows.Forms.Label label2;
    }
}