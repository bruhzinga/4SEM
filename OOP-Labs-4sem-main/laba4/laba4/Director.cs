using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class Director
    {
        public void Construct(IAccoutBuilder builder, IOwnerBuilder builder2)
        {
            builder.BuildSMS();
            builder.BuildBalance();
            builder.BuildDate();
            builder.BuildType();
            builder.BuildDate();
            builder.BuildNum();
            builder2.BuildDate();
            builder2.BuildName();
            builder2.BuildPassport();
        }
    }
}