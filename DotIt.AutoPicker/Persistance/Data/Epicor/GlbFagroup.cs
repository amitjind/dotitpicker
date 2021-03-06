﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbFagroup
    {
        public bool AdditionSpread { get; set; }
        public string AssetMethod { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool Finalspread { get; set; }
        public string GroupCode { get; set; }
        public string JournalCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbGroupCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFagroup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
