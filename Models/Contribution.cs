using System;
using System.Collections.Generic;

namespace bank.Models
{
    public partial class Contribution
    {
        public long CodeOfContribution { get; set; }
        public long NameOfContribution { get; set; }
        public long MinTimeOfDeposit { get; set; }
        public long MaxTimeOfDeposit { get; set; }
        public long InterestRate { get; set; }
        public long AdditionalConditions { get; set; }
    }
}
