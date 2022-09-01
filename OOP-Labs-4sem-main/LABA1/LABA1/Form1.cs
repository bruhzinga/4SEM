namespace LABA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += AddText;
            button2.Click += AddText;
            button3.Click += AddText;
            button4.Click += AddText;
            button5.Click += AddText;
            button6.Click += AddText;
            button7.Click += AddText;
            button8.Click += AddText;
            button9.Click += AddText;
            button10.Click += AddText;
            button18.Click += AddText;

            button14.Click += Operations;
            button15.Click += Operations;
            button16.Click += Operations;
            button11.Click += Operations;
            button12.Click += Operations;
            buttonSave.Click += Operations;
            button17.Click += Operations;

            buttonSave.Click += Save;
            buttonLoad.Click += Load;
            buttonSqr3.Click += Operations;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddText(object sender,EventArgs e)
        {
            var obj = sender as Button;
            this.textBox1.Text += obj.Text;
        }

        public void Operations(object sender, EventArgs e)
        {
            try
            {
                var temp = float.Parse(textBox1.Text);
                switch ((sender as Button).Text)
                {
                    case "sqr":
                        textBox1.Text = Math.Sqrt(temp).ToString();
                        break;
                    case "C":
                        textBox1.Text = "";
                        break;
                    case "^":
                        textBox1.Text = Math.Pow(temp, 2).ToString();
                        break;
                    case "cos":
                        textBox1.Text = Math.Cos(temp).ToString();
                        break;
                    case "sin":
                        textBox1.Text = Math.Sin(temp).ToString();
                        break;
                    case "tan":
                        textBox1.Text = Math.Tan(temp).ToString();
                        break;
                    case "cot":
                        textBox1.Text = Math.Atan(temp).ToString();
                        break;
                    case "sqr3":
                        textBox1.Text = Math.Pow(temp, -3).ToString();
                        break;




                }
                Convert.ToDecimal(textBox1.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Õ≈«ﬂ");
                textBox1.Text = "";

            }


        }
        public void Save(object sender,EventArgs e)
        {
            using(var file = new StreamWriter("nums.txt",false))
            {
                file.WriteLine(textBox1.Text);

            }


        }
        public void Load(object sender,EventArgs e)
        {
            using (var file = new StreamReader("nums.txt", false))
            {
                textBox1.Text=file.ReadToEnd();

            }
        }


    }
}