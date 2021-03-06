﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ingstr2matchedLine
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Section { get; set; }
        public int TransactionType { get; set; }
        public Guid ExternalSysRowId { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public int IntKey1 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
