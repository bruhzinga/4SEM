using LABA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public interface Ishow
    {
        public string Show();
    }

    public class Adapter1 : Ishow
    {
        private readonly Account _adaptee;

        public Adapter1(Account adaptee)
        {
            this._adaptee = adaptee;
        }

        public string Show()
        {
            return $"Number: {_adaptee.num}";
        }

        public override string ToString()
        {
            return Show();
        }
    }

    public class Adapter2 : Ishow
    {
        private readonly Account _adaptee;

        public Adapter2(Account adaptee)
        {
            this._adaptee = adaptee;
        }

        public string Show()
        {
            return $"Name:{_adaptee.owner.Name} Birtdate:{_adaptee.owner.Birtdate}";
        }

        public override string ToString()
        {
            return Show();
        }
    }
}