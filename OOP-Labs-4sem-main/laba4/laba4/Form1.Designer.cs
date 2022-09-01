namespace LABA2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.opendate = new System.Windows.Forms.DateTimePicker();
            this.sms = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГодуОткрытияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типВкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.passport = new System.Windows.Forms.TextBox();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(3, 105);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(125, 27);
            this.num.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип вклада:";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Открытй",
            "Закрытый"});
            this.type.Location = new System.Drawing.Point(3, 158);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(151, 28);
            this.type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Баланс:";
            // 
            // balance
            // 
            this.balance.LargeChange = 250;
            this.balance.Location = new System.Drawing.Point(3, 223);
            this.balance.Maximum = 1000000;
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(255, 56);
            this.balance.SmallChange = 20;
            this.balance.TabIndex = 5;
            this.balance.Scroll += new System.EventHandler(this.balance_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата открытия:";
            // 
            // opendate
            // 
            this.opendate.Location = new System.Drawing.Point(3, 285);
            this.opendate.Name = "opendate";
            this.opendate.Size = new System.Drawing.Size(250, 27);
            this.opendate.TabIndex = 7;
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Location = new System.Drawing.Point(3, 331);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(242, 24);
            this.sms.TabIndex = 8;
            this.sms.Text = "подключены смс оповещения";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Владелец";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = " ФИО:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(8, 416);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 11;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(8, 473);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(250, 27);
            this.birthdate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата рожения:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(173, 85);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 102);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Добавить!";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(347, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(736, 584);
            this.listBox1.TabIndex = 22;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 532);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 102);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Сохранить!";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(130, 532);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(101, 102);
            this.buttonLoad.TabIndex = 24;
            this.buttonLoad.Text = "Загрузить!";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem2,
            this.сортировкаToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.отменитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // поискToolStripMenuItem2
            // 
            this.поискToolStripMenuItem2.Name = "поискToolStripMenuItem2";
            this.поискToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.поискToolStripMenuItem2.Text = "Поиск";
            this.поискToolStripMenuItem2.Click += new System.EventHandler(this.поискToolStripMenuItem2_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруToolStripMenuItem,
            this.поГодуОткрытияToolStripMenuItem,
            this.типВкладаToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поНомеруToolStripMenuItem
            // 
            this.поНомеруToolStripMenuItem.Name = "поНомеруToolStripMenuItem";
            this.поНомеруToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.поНомеруToolStripMenuItem.Text = "По Номеру";
            this.поНомеруToolStripMenuItem.Click += new System.EventHandler(this.поНомеруToolStripMenuItem_Click);
            // 
            // поГодуОткрытияToolStripMenuItem
            // 
            this.поГодуОткрытияToolStripMenuItem.Name = "поГодуОткрытияToolStripMenuItem";
            this.поГодуОткрытияToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.поГодуОткрытияToolStripMenuItem.Text = "По Году открытия";
            this.поГодуОткрытияToolStripMenuItem.Click += new System.EventHandler(this.поГодуОткрытияToolStripMenuItem_Click);
            // 
            // типВкладаToolStripMenuItem
            // 
            this.типВкладаToolStripMenuItem.Name = "типВкладаToolStripMenuItem";
            this.типВкладаToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.типВкладаToolStripMenuItem.Text = "Тип Вклада";
            this.типВкладаToolStripMenuItem.Click += new System.EventHandler(this.типВкладаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Паспорт";
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(144, 416);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(162, 27);
            this.passport.TabIndex = 27;
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 681);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.opendate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Счет";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox num;
        private Label label2;
        private ComboBox type;
        private Label label3;
        private TrackBar balance;
        private Label label4;
        private DateTimePicker opendate;
        private CheckBox sms;
        private Label label5;
        private Label label6;
        private TextBox name;
        private DateTimePicker birthdate;
        private Label label7;
        private Button addButton;
        private ListBox listBox1;
        private Button buttonSave;
        private Button buttonLoad;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label8;
        private TextBox passport;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem поНомеруToolStripMenuItem;
        private ToolStripMenuItem поГодуОткрытияToolStripMenuItem;
        private ToolStripMenuItem типВкладаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
    }
}