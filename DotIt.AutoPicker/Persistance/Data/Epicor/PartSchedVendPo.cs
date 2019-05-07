﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartSchedVendPo
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ContractPonum { get; set; }
        public int ContractPoline { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsExpired { get; set; }
        public bool IsApproved { get; set; }
        public int PercentShare { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}