﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImhxpbschWrk
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int Revision { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime? EstComplDte { get; set; }
        public DateTime? PlanCmplDte { get; set; }
        public string ProjectId { get; set; }
        public string SchWrkId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
