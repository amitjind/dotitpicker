﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class UstinvalidationResult
    {
        public string Company { get; set; }
        public string TinvalidationResultId { get; set; }
        public string Description { get; set; }
        public string TinvalidationId { get; set; }
        public int EftheadUid { get; set; }
        public string ImportFile { get; set; }
        public bool Imported { get; set; }
        public string ImportSummary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
