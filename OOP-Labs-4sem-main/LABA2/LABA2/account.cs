using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2
{
    public class Account
    {
        public int num;
        public enum Types { closed,open};
        public Types Type;
        public int Balance;
        public DateTime OpeningDate;
        public bool Sms= false;
      
        public Owner owner;
        public Account()
        {
            owner = new Owner();

        }

        public class Owner
        {
            public string Name;
            public DateTime Birtdate;
            public string Passport;

        }

        public override string ToString()
        {
            return $"Number: {num} Type:{Type} SMS: {Sms} Name:{owner.Name} Birtdate:{owner.Birtdate}";
        }

    }
}
