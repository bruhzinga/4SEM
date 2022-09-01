using LABA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class RandomAccountBuilder : IAccoutBuilder, IOwnerBuilder
    {
        private Account _product;

        public RandomAccountBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Account();
        }

        public void BuildBalance()
        {
            Random random = new Random();
            _product.Balance = random.Next(0, 1000000);
        }

        void IAccoutBuilder.BuildDate()
        {
            _product.OpeningDate = DateTime.Now;
        }

        void IOwnerBuilder.BuildDate()
        {
            _product.owner.Birtdate = DateTime.Now;
        }

        public void BuildNum()
        {
            Random random = new Random();
            _product.num = random.Next(0, 1000000);
        }

        public void BuildSMS()
        {
            Random random = new Random();
            _product.Sms = Convert.ToBoolean(random.Next(2));
        }

        public void BuildType()
        {
            Random random = new Random();
            if (random.Next(2) == 1)
            {
                this._product.Type = Account.Types.open;
            }
            else
                this._product.Type = Account.Types.closed;
        }

        public void BuildName()
        {
            Random random = new Random();
            var stringnames = "Olivia Emma Ava Charlotte Sophia Liam Noah Oliver Elijah William"
                + "Olivia Emma Ava Sophia Isabella Liam Noah Oliver William Elijah";

            var names = stringnames.Split(" ");
            _product.owner.Name = names[random.Next(0, names.Length)];
        }

        public void BuildPassport()
        {
            _product.owner.Passport = "1234567A123РБ1";
        }

        public Account GetResult()
        {
            return _product;
        }
    }
}