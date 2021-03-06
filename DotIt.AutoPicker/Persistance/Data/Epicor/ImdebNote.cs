﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImdebNote
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int DebitNoteId { get; set; }
        public int CustNum { get; set; }
        public string DncustNbr { get; set; }
        public decimal Dnamount { get; set; }
        public decimal DocDnamount { get; set; }
        public int DninvNbr { get; set; }
        public bool Dnapplied { get; set; }
        public string DnappliedTo { get; set; }
        public int CashHeadNum { get; set; }
        public string GroupId { get; set; }
        public bool PmtPosted { get; set; }
        public string Dncomments { get; set; }
        public DateTime? DndueDate { get; set; }
        public DateTime? Dndate { get; set; }
        public bool InvcChanged { get; set; }
        public int InvNbrAssigned { get; set; }
        public decimal Rpt1Dnamount { get; set; }
        public decimal Rpt2Dnamount { get; set; }
        public decimal Rpt3Dnamount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
