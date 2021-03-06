﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtfordSug
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TfordNum { get; set; }
        public int TfordLine { get; set; }
        public string SuggestionCode { get; set; }
        public DateTime? RequireDate { get; set; }
        public string SourceName { get; set; }
        public decimal SurplusQty { get; set; }
        public string CancelReason { get; set; }
        public string Comment { get; set; }
        public string Plant { get; set; }
        public bool OrderFirm { get; set; }
        public string TflineNum { get; set; }
        public string PartNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
