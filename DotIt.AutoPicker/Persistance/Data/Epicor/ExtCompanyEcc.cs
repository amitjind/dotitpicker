﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtCompanyEcc
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string ExtSystemId { get; set; }
        public int Eccid { get; set; }
        public string Eccurl { get; set; }
        public string Eccpassword { get; set; }
        public string DefaultEpicorUserId { get; set; }
        public int DefaultEpicorCustNum { get; set; }
        public string DefaultMiscChargeCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DefaultDiscountCode { get; set; }
        public string TaskSetId { get; set; }
        public string DocTypeId { get; set; }
        public string Cncprefix { get; set; }
        public int Cncseq { get; set; }
        public int TimeOutLimit { get; set; }
        public int RecycleLimit { get; set; }
        public bool UseLocation { get; set; }
        public string EccsiteName { get; set; }
        public string WfgroupId { get; set; }
        public string BtcashGrpPfx { get; set; }
        public string BtdefBankAcctId { get; set; }
    }
}
