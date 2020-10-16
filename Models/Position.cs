using System;
using System.Collections.Generic;

namespace bank.Models
{
    public partial class Position
    {
        public long CodeOfPosition { get; set; }
        public long NameOfPosition { get; set; }
        public long Salary { get; set; }
        public long Duties { get; set; }
        public long Requirements { get; set; }
    }
}
