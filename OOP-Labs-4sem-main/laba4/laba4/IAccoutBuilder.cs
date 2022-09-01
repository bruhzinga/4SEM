using LABA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal interface IAccoutBuilder
    {
        void BuildNum();

        void BuildType();

        void BuildBalance();

        void BuildDate();

        void BuildSMS();

        public Account GetResult();
    }
}