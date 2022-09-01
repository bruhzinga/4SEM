using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LABA3
{
    public class PassportRB : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var reg = new Regex(@"\d{7}А\d{3}РБ\d");
            return reg.IsMatch((value as string));
        }
    }
}