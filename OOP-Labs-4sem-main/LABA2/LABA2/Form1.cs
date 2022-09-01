using Newtonsoft.Json;
using System.Text.Json;

namespace LABA2
{
    public partial class Form1 : Form
    {
        public Account account;
        public List<Account> accounts;
        public Form1()
        {
           
            InitializeComponent();
            accounts = new List<Account>();
            
          
        }

        

        private void balance_Scroll(object sender, EventArgs e)
        {
            label3.Text = $"БАЛАНС: {(sender as TrackBar).Value}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (balance.Value == 0 || num.Text == "" || type.Text == "" || name.Text == "")
            { MessageBox.Show("Введи все Данные"); return; }
            account = new Account();
            account.num = int.Parse(num.Text);

            account.Balance = balance.Value;
            if (sms.Checked)
                account.Type = Account.Types.open;
            account.Type = Account.Types.closed;

            account.Sms = sms.Checked;
            account.OpeningDate = opendate.Value;
            account.owner = new Account.Owner()
            { Birtdate = opendate.Value,
                Name = name.Text,
            };

            listBox1.Items.Add(account);
            
            accounts.Add(account);






        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using(var file = new StreamWriter("file.txt",false))
            {
                file.Write(JsonConvert.SerializeObject(accounts));
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (var file = new StreamReader("file.txt", false))
            {
                var temp = JsonConvert.DeserializeObject<List<Account>>(file.ReadToEnd());
                listBox1.Items.Clear();
                foreach(var t in temp)
                {
                    listBox1.Items.Add(t);
                }
            }
        }
    }
}