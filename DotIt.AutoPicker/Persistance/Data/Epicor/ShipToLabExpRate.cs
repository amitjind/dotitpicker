﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShipToLabExpRate
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string ExpenseCode { get; set; }
        public int RateType { get; set; }
        public decimal RateMultiplier { get; set; }
        public decimal FixedRate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
