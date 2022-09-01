using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LABA3;
using laba4;

namespace LABA2
{
    public class Account : Ishow
    {
        public Account()
        {
            num = 0;
            Type = Types.closed;
            Balance = 0;
            OpeningDate = DateTime.Now;
            owner = new Owner() { Name = null, Birtdate = null, Passport = null };
        }

        [Range(0, 100)]
        [Required]
        public int num { get; set; }

        public enum Types
        { closed, open };

        [Required]
        public Types Type;

        [Range(0, 10000000)]
        [Required]
        public int Balance { get; set; }

        [Required]
        public DateTime OpeningDate;

        public bool Sms = false;

        [Required]
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
            [Required]
            public string Name { get; set; }

            public DateTime? Birtdate;

            [PassportRB]
            [Required]
            public string Passport { get; set; }
        }

        public override string ToString()
        {
            return Show();
        }

        public virtual string Show()
        {
            return $"Number: {num} Type:{Type} SMS: {Sms} \n Name:{owner.Name} Birtdate:{owner.Birtdate} ";
        }

        public Account Clone()
        {
            return (Account)this.MemberwiseClone();
        }
    }
}