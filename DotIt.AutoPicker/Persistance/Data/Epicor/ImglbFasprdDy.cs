﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbFasprdDy
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Days { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalPeriod { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string SpreadCode { get; set; }
        public decimal SpreadValue { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSpreadCode { get; set; }
        public int GlbFiscalYear { get; set; }
        public string GlbFiscalYearSuffix { get; set; }
        public int GlbFiscalPeriod { get; set; }
        public string GlbFiscalCalendarId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFasprdDy { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
