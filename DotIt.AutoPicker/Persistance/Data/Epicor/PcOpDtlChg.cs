﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcOpDtlChg
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public int ChgSeq { get; set; }
        public Guid BomelementSysRowId { get; set; }
        public int OrigOpDtlSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
