﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPcDynLstExpr
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string InputName { get; set; }
        public int ListSeq { get; set; }
        public string TypeCode { get; set; }
        public int SeqNum { get; set; }
        public string Expression { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
