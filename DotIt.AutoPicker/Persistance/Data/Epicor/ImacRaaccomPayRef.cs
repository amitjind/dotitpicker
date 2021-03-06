﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacRaaccomPayRef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal Raid { get; set; }
        public decimal RaaccomPayId { get; set; }
        public decimal RaaccomPayRefId { get; set; }
        public string BschHeadCd { get; set; }
        public string BaseBcd { get; set; }
        public string Mpirbcd { get; set; }
        public int BaseInvoiceNum { get; set; }
        public int MpirinvoiceNum { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
