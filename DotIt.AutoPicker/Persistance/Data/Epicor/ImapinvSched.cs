﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImapinvSched
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int PaySeq { get; set; }
        public int PayDays { get; set; }
        public DateTime? PayDueDate { get; set; }
        public decimal DocPayAmount { get; set; }
        public decimal PayAmount { get; set; }
        public decimal Rpt1PayAmount { get; set; }
        public decimal Rpt2PayAmount { get; set; }
        public decimal Rpt3PayAmount { get; set; }
        public decimal PayPercent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbInvoiceNum { get; set; }
        public int GlbPaySeq { get; set; }
    }
}
