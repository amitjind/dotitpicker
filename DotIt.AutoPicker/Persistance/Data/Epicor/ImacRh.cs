﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacRh
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal Rhid { get; set; }
        public int CustNum { get; set; }
        public bool PrefBurial { get; set; }
        public bool PrefCremation { get; set; }
        public string MedicalCond { get; set; }
        public string FuneralNotes { get; set; }
        public string Restrictions { get; set; }
        public string PersonalHist { get; set; }
        public string WillLodgement { get; set; }
        public decimal RmobTpId { get; set; }
        public bool IsConfused { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
