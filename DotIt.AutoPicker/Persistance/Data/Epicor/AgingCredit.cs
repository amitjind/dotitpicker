﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AgingCredit
    {
        public string Company { get; set; }
        public string AgingCreditCode { get; set; }
        public string Description { get; set; }
        public bool AgingCreditDefault { get; set; }
        public int AgingDays { get; set; }
        public int PaymentProcessDays { get; set; }
        public decimal MinimumBaseBalance { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
