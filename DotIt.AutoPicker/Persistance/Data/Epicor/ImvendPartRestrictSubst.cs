﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImvendPartRestrictSubst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public string Pum { get; set; }
        public int VendorNum { get; set; }
        public string RestrictionTypeId { get; set; }
        public string SubstanceId { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public bool Manual { get; set; }
        public DateTime? ExemptDate { get; set; }
        public string ExemptCertificate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}