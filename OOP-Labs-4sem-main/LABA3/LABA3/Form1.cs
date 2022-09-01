using LABA3;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LABA2
{
    public partial class Form1 : Form
    {
        public List<Account> accounts;
        private IOrderedEnumerable<Account> account;

        public Form1()
        {
            InitializeComponent();
            accounts = new List<Account>();
        }

        private void balance_Scroll(object sender, EventArgs e)
        {
            label3.Text = $"¡¿À¿Õ—: {(sender as TrackBar).Value}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (balance.Value == 0 || num.Text == "" || type.Text == "" || name.Text == "")
                { MessageBox.Show("¬‚Â‰Ë ‚ÒÂ ƒ‡ÌÌ˚Â"); return; }
                var account = new Account(int.Parse(num.Text), Account.Types.open, balance.Value, opendate.Value, sms.Checked, new Account.Owner()
                {
                    Birtdate = opendate.Value,
                    Name = name.Text,
                    Passport = passport.Text,
                });

                if (!sms.Checked)
                    account.Type = Account.Types.closed;
                if (type.Text == "«‡Í˚Ú˚È")
                {
                    account.Type = Account.Types.closed;
                }

                ValidationContext context = new ValidationContext(account, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                ValidationContext context2 = new ValidationContext(account.owner, null, null);

                if (!Validator.TryValidateObject(account, context, errors, true) || !Validator.TryValidateObject(account.owner, context2, errors, true))
                {
                    foreach (ValidationResult result in errors)
                        MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    MessageBox.Show("Validated");
                    listBox1.Items.Add(account);
                    accounts.Add(account);
                }
            }
            catch
            {
                MessageBox.Show("Õ≈«ﬂ");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var file = new StreamWriter("file.txt", false))
            {
                file.Write(JsonConvert.SerializeObject(accounts));
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (var file = new StreamReader("file.txt", false))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(file.ReadToEnd());
                listBox1.Items.Clear();
                foreach (var t in accounts)
                {
                    listBox1.Items.Add(t);
                }
            }
        }

        private void ÔÓËÒÍToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Search = new Form2(accounts);
            Search.ShowDialog();
        }

        private void ÔÓÕÓÏÂÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.num).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }
        }

        private void ÔÓ√Ó‰ÛŒÚÍ˚ÚËˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.OpeningDate).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }
        }

        private void ÚËÔ¬ÍÎ‡‰‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.Type).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }
        }
    }
}