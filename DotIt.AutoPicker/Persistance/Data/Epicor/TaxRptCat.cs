﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxRptCat
    {
        public string Company { get; set; }
        public string RptCatCode { get; set; }
        public string Description { get; set; }
        public bool GlobalTaxRptCat { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
