﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbTaskType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool Appointment { get; set; }
        public string Company { get; set; }
        public bool ExpenseTaskType { get; set; }
        public bool Inactive { get; set; }
        public bool TimeTaskType { get; set; }
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTypeCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaskType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
