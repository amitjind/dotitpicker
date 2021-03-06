﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbBdnCd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public decimal ActBdnPcnt { get; set; }
        public DateTime? ActEffDte { get; set; }
        public string BdnCd { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public bool UseAllPrjRole { get; set; }
        public string GlbCompany { get; set; }
        public string GlbBdnCd { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalBdnCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
