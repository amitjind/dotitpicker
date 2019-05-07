﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImhxpphaseOper
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
        public decimal EstHours { get; set; }
        public string OpCode { get; set; }
        public string PhaseId { get; set; }
        public string ProjectId { get; set; }
        public string RoleCd { get; set; }
        public int Seq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}