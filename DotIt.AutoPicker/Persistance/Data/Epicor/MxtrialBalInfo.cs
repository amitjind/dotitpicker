﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MxtrialBalInfo
    {
        public string Company { get; set; }
        public string BookId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriodStart { get; set; }
        public int FiscalPeriodEnd { get; set; }
        public DateTime? PostDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
