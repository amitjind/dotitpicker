﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxRgnSalesTax
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxRegionCode { get; set; }
        public string TaxCode { get; set; }
        public string TaxMethod { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public int TaxNum { get; set; }
        public bool GlobalTaxRgnSalesTax { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
