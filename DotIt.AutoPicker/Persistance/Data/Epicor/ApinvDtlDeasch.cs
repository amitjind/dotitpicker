﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ApinvDtlDeasch
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int AmortSeq { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public DateTime? AmortDate { get; set; }
        public decimal AmortPercent { get; set; }
        public decimal AmortAmt { get; set; }
        public decimal Rpt1AmortAmt { get; set; }
        public decimal Rpt2AmortAmt { get; set; }
        public decimal Rpt3AmortAmt { get; set; }
        public decimal DocAmortAmount { get; set; }
        public bool Hold { get; set; }
        public string HoldReasonCode { get; set; }
        public string HoldText { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ApinvDtl ApinvDtl { get; set; }
    }
}
