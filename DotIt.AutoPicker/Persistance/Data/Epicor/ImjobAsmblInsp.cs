﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImjobAsmblInsp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int PlanSeq { get; set; }
        public string InspPlanPartNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
