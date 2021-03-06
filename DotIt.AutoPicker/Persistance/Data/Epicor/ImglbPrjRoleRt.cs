﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPrjRoleRt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
        public DateTime? RateEffDte { get; set; }
        public DateTime? RateEndDte { get; set; }
        public string RoleCd { get; set; }
        public int Seq { get; set; }
        public string TimeTypCd { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRoleCd { get; set; }
        public int GlbSeq { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPrjRoleRt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
