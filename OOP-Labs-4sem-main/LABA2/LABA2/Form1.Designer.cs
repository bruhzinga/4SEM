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
            ((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(12, 32);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(125, 27);
            this.num.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
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
            this.type.Location = new System.Drawing.Point(12, 85);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(151, 28);
            this.type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Баланс:";
            // 
            // balance
            // 
            this.balance.LargeChange = 250;
            this.balance.Location = new System.Drawing.Point(12, 150);
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
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата открытия:";
            // 
            // opendate
            // 
            this.opendate.Location = new System.Drawing.Point(12, 212);
            this.opendate.Name = "opendate";
            this.opendate.Size = new System.Drawing.Size(250, 27);
            this.opendate.TabIndex = 7;
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Location = new System.Drawing.Point(12, 258);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(242, 24);
            this.sms.TabIndex = 8;
            this.sms.Text = "подключены смс оповещения";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Владелец";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = " ФИО:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(17, 343);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 11;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(17, 400);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(250, 27);
            this.birthdate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата рожения:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(182, 12);
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
            this.listBox1.Location = new System.Drawing.Point(356, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 584);
            this.listBox1.TabIndex = 22;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 459);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 102);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Сохранить!";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(139, 459);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(101, 102);
            this.buttonLoad.TabIndex = 24;
            this.buttonLoad.Text = "Загрузить!";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 626);
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
            this.Name = "Form1";
            this.Text = "Счет";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
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
    }
}