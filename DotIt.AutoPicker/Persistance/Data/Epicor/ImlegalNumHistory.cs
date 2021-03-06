﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImlegalNumHistory
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string LegalNumber { get; set; }
        public DateTime? TranDate { get; set; }
        public string LegalNumberId { get; set; }
        public bool TranComplete { get; set; }
        public bool Voided { get; set; }
        public string VoidedByUser { get; set; }
        public DateTime? VoidedDate { get; set; }
        public string VoidedReason { get; set; }
        public string RelatedToFile { get; set; }
        public string ForeignKey { get; set; }
        public string PrintedLegalNumber { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CreatedBy { get; set; }
        public string PostedBy { get; set; }
        public string WarehouseCode { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool IsUserDependent { get; set; }
        public string TranDocTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
