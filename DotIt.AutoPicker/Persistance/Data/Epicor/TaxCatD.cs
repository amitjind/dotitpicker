﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxCatD
    {
        public string Company { get; set; }
        public string TaxCatId { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public bool GlobalTaxCatD { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
