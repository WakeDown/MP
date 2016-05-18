namespace ExcelAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.editBox2 = this.Factory.CreateRibbonEditBox();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.editBox3 = this.Factory.CreateRibbonEditBox();
            this.editBox4 = this.Factory.CreateRibbonEditBox();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.editBox5 = this.Factory.CreateRibbonEditBox();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.editBox6 = this.Factory.CreateRibbonEditBox();
            this.editBox7 = this.Factory.CreateRibbonEditBox();
            this.separator4 = this.Factory.CreateRibbonSeparator();
            this.editBox8 = this.Factory.CreateRibbonEditBox();
            this.editBox9 = this.Factory.CreateRibbonEditBox();
            this.separator5 = this.Factory.CreateRibbonSeparator();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.button6 = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.button3);
            this.group1.Items.Add(this.button9);
            this.group1.Label = "Супер кнопки";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.editBox5);
            this.group2.Items.Add(this.button5);
            this.group2.Items.Add(this.separator3);
            this.group2.Items.Add(this.editBox6);
            this.group2.Items.Add(this.button6);
            this.group2.Items.Add(this.separator4);
            this.group2.Items.Add(this.editBox7);
            this.group2.Items.Add(this.editBox8);
            this.group2.Items.Add(this.button7);
            this.group2.Items.Add(this.separator5);
            this.group2.Items.Add(this.editBox9);
            this.group2.Items.Add(this.button8);
            this.group2.Label = "Работа с клиентами";
            this.group2.Name = "group2";
            // 
            // group3
            // 
            this.group3.Items.Add(this.button4);
            this.group3.Items.Add(this.separator2);
            this.group3.Items.Add(this.label1);
            this.group3.Items.Add(this.editBox1);
            this.group3.Items.Add(this.editBox2);
            this.group3.Items.Add(this.separator1);
            this.group3.Items.Add(this.label2);
            this.group3.Items.Add(this.editBox3);
            this.group3.Items.Add(this.editBox4);
            this.group3.Label = "Работа с матрицами";
            this.group3.Name = "group3";
            // 
            // label1
            // 
            this.label1.Label = "Размеры матрицы А";
            this.label1.Name = "label1";
            // 
            // editBox1
            // 
            this.editBox1.Label = "Строки   ";
            this.editBox1.Name = "editBox1";
            this.editBox1.Text = null;
            // 
            // editBox2
            // 
            this.editBox2.Label = "Столбцы";
            this.editBox2.Name = "editBox2";
            this.editBox2.Text = null;
            // 
            // label2
            // 
            this.label2.Label = "Размеры матрицы Б";
            this.label2.Name = "label2";
            // 
            // editBox3
            // 
            this.editBox3.Label = "Строки   ";
            this.editBox3.Name = "editBox3";
            this.editBox3.Text = null;
            // 
            // editBox4
            // 
            this.editBox4.Label = "Столбцы";
            this.editBox4.Name = "editBox4";
            this.editBox4.Text = null;
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // editBox5
            // 
            this.editBox5.Label = "Первый символ:";
            this.editBox5.Name = "editBox5";
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            // 
            // editBox6
            // 
            this.editBox6.Label = "Символы:";
            this.editBox6.Name = "editBox6";
            // 
            // editBox7
            // 
            this.editBox7.Label = "Сумма от:";
            this.editBox7.Name = "editBox7";
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            // 
            // editBox8
            // 
            this.editBox8.Label = "Сумма до:";
            this.editBox8.Name = "editBox8";
            // 
            // editBox9
            // 
            this.editBox9.Label = "Супер фильтр:";
            this.editBox9.Name = "editBox9";
            // 
            // separator5
            // 
            this.separator5.Name = "separator5";
            // 
            // button1
            // 
            this.button1.Image = global::ExcelAddIn.Properties.Resources.sort_by_attributes_interface_button_option;
            this.button1.Label = "Сортировка";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ExcelAddIn.Properties.Resources.countdown_1_;
            this.button2.Label = "Непустые ячейки";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ExcelAddIn.Properties.Resources.sinusoid_graph;
            this.button3.Label = "2 задание";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button9.Image = global::ExcelAddIn.Properties.Resources.bookmark_button;
            this.button9.Label = "Анализ";
            this.button9.Name = "button9";
            this.button9.ShowImage = true;
            this.button9.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Image = global::ExcelAddIn.Properties.Resources.search;
            this.button5.Label = "Найти";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = global::ExcelAddIn.Properties.Resources.search;
            this.button6.Label = "Найти";
            this.button6.Name = "button6";
            this.button6.ShowImage = true;
            this.button6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Image = global::ExcelAddIn.Properties.Resources.search;
            this.button7.Label = "Найти";
            this.button7.Name = "button7";
            this.button7.ShowImage = true;
            this.button7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Image = global::ExcelAddIn.Properties.Resources.search;
            this.button8.Label = "Найти";
            this.button8.Name = "button8";
            this.button8.ShowImage = true;
            this.button8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button4.Image = global::ExcelAddIn.Properties.Resources.matrix_scene;
            this.button4.Label = "Матрицы";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox3;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox4;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator4;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox7;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator5;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
