﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SugPoMsc
    {
        public string Company { get; set; }
        public int SugNum { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public bool Taxable { get; set; }
        public string GlbCompany { get; set; }
        public bool GlbSuggestion { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
