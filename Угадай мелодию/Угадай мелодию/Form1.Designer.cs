namespace Угадай_мелодию
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.butPlay = new System.Windows.Forms.Button();
            this.butOptions = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butPlay
            // 
            this.butPlay.Location = new System.Drawing.Point(12, 12);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(129, 45);
            this.butPlay.TabIndex = 0;
            this.butPlay.Text = "Игра";
            this.butPlay.UseVisualStyleBackColor = true;
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butOptions
            // 
            this.butOptions.Location = new System.Drawing.Point(140, 63);
            this.butOptions.Name = "butOptions";
            this.butOptions.Size = new System.Drawing.Size(129, 45);
            this.butOptions.TabIndex = 1;
            this.butOptions.Text = "Настройки";
            this.butOptions.UseVisualStyleBackColor = true;
            this.butOptions.Click += new System.EventHandler(this.butOptions_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(12, 114);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(129, 45);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Угадай_мелодию.Properties.Resources.preview;
            this.ClientSize = new System.Drawing.Size(275, 332);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOptions);
            this.Controls.Add(this.butPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.Text = "Угадай мелодию";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPlay;
        private System.Windows.Forms.Button butOptions;
        private System.Windows.Forms.Button butExit;
    }
}

