﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImhxpbempCeiling
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int Revision { get; set; }
        public decimal Ceiling { get; set; }
        public string Company { get; set; }
        public decimal DocCeiling { get; set; }
        public string EmpId { get; set; }
        public string ProjectId { get; set; }
        public decimal Rpt1Ceiling { get; set; }
        public decimal Rpt2Ceiling { get; set; }
        public decimal Rpt3Ceiling { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
