﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbConsSrcRates
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public int GlbGenId { get; set; }
        public string GlbSourceBook { get; set; }
        public int GlbFiscalYear { get; set; }
        public string GlbFiscalYearSuffix { get; set; }
        public int GlbFiscalPeriod { get; set; }
        public string GlbRateTypeId { get; set; }
        public int GenId { get; set; }
        public string SourceBook { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string RateTypeId { get; set; }
        public string FiscalCalendarId { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool UserModified { get; set; }
        public bool RateError { get; set; }
        public DateTime? CalcDate { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
