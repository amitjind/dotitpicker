﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpegljrnDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public Guid GljrnDtlSysRowId { get; set; }
        public bool F51 { get; set; }
        public bool F53 { get; set; }
        public bool F61 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool F81 { get; set; }
        public bool F82 { get; set; }
        public bool F14 { get; set; }
    }
}