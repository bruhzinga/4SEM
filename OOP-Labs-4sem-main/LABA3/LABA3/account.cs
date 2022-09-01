using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LABA3;

namespace LABA2
{
    public class Account
    {
        [Range(0, 100)]
        public int num { get; set; }

        public enum Types
        { closed, open };

        public Types Type;

        [Range(0, 10000000)]
        public int Balance { get; set; }

        public DateTime OpeningDate;
        public bool Sms = false;

        public Owner owner;

        public Account(int num, Types type, int balance, DateTime openingDate, bool sms, Owner owner)
        {
            this.num = num;
            Type = type;
            Balance = balance;
            OpeningDate = openingDate;
            Sms = sms;
            this.owner = owner;
        }

        public class Owner
        {
            [StringLength(10)]
            public string Name { get; set; }

            public DateTime Birtdate;

            [PassportRB]
            public string Passport { get; set; }
        }

        public override string ToString()
        {
            return $"Number: {num} Type:{Type} SMS: {Sms} \n Name:{owner.Name} Birtdate:{owner.Birtdate}";
        }
    }
}