using System;
using System.Collections.Generic;

namespace bank.Models
{
    public partial class Currency
    {
        public long CodeOfCurrency { get; set; }
        public long Name { get; set; }
        public long ExchangeRate { get; set; }
    }
}
