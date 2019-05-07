﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CurrConvRule
    {
        public string Company { get; set; }
        public string SourceCurrCode { get; set; }
        public string TargetCurrCode { get; set; }
        public string RateGrpCode { get; set; }
        public bool UseBaseRate { get; set; }
        public int RuleCode { get; set; }
        public bool FixedRate { get; set; }
        public int DisplayMode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}