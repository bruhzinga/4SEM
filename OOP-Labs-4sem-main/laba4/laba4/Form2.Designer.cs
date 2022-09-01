namespace LABA3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.checksearch = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.BALANCE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.TYPE = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регулярное выражение:";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(12, 32);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(174, 27);
            this.textsearch.TabIndex = 1;
            // 
            // checksearch
            // 
            this.checksearch.AutoSize = true;
            this.checksearch.Location = new System.Drawing.Point(12, 65);
            this.checksearch.Name = "checksearch";
            this.checksearch.Size = new System.Drawing.Size(177, 24);
            this.checksearch.TabIndex = 2;
            this.checksearch.Text = "Расширенный Поиск";
            this.checksearch.UseVisualStyleBackColor = true;
            this.checksearch.CheckedChanged += new System.EventHandler(this.checksearch_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО";
            this.label2.Visible = false;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(12, 115);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(174, 27);
            this.FIO.TabIndex = 5;
            this.FIO.Visible = false;
            // 
            // BALANCE
            // 
            this.BALANCE.Location = new System.Drawing.Point(12, 168);
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Size = new System.Drawing.Size(174, 27);
            this.BALANCE.TabIndex = 7;
            this.BALANCE.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Баланс";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип вклада";
            this.label4.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(23, 294);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(148, 79);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "ПОИСК!";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // TYPE
            // 
            this.TYPE.FormattingEnabled = true;
            this.TYPE.Items.AddRange(new object[] {
            "Открытй",
            "Закрытый"});
            this.TYPE.Location = new System.Drawing.Point(12, 231);
            this.TYPE.Name = "TYPE";
            this.TYPE.Size = new System.Drawing.Size(151, 28);
            this.TYPE.TabIndex = 11;
            this.TYPE.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(248, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 344);
            this.listBox1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 448);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TYPE);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BALANCE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checksearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textsearch;
        private CheckBox checksearch;
        private Label label2;
        private TextBox FIO;
        private TextBox BALANCE;
        private Label label3;
        private Label label4;
        private Button buttonSearch;
        private ComboBox TYPE;
        private ListBox listBox1;
    }
}