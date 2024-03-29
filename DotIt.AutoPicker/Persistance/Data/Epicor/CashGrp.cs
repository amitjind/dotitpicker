﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CashGrp
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public DateTime? TranDate { get; set; }
        public string CreatedBy { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string ActiveUserId { get; set; }
        public string BankAcctId { get; set; }
        public bool Cashbook { get; set; }
        public bool DebNoteOnly { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public bool PromissoryNote { get; set; }
        public int Pmuid { get; set; }
        public bool EipaymSent { get; set; }
        public string Pistatus { get; set; }
        public bool PistatusGrp { get; set; }
        public string Pitype { get; set; }
        public bool AutoGenerated { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public Guid BankBatchSysRowId { get; set; }
    }
}
