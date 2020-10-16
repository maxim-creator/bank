using System;
using System.Collections.Generic;

namespace bank.Models
{
    public partial class Depositor
    {
        public long CodeOfEmployee { get; set; }
        public long PassportData { get; set; }
        public long DateOfContribution { get; set; }
        public long ReturnDate { get; set; }
        public long CodeOfContribution { get; set; }
        public long DepositAmount { get; set; }
        public long AmountOfTheRefund { get; set; }
        public long MarkTheReturnOfTheDepositbute { get; set; }
        public long Name { get; set; }
        public long Address { get; set; }
        public long Phone { get; set; }
    }
}
