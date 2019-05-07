﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcBrateUpdGrp
    {
        public string Company { get; set; }
        public decimal BrateUpdGrpId { get; set; }
        public string BrateGroup { get; set; }
        public DateTime? EffDt { get; set; }
        public bool UpdOvrRates { get; set; }
        public string BillSchedules { get; set; }
        public DateTime? BrateUpdatedDt { get; set; }
        public int BrateUpdatedTime { get; set; }
        public bool Posted { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string ClientCustNumList { get; set; }
        public string Bcdlist { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}