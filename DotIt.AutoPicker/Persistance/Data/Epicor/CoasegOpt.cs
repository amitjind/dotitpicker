﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CoasegOpt
    {
        public string Company { get; set; }
        public string Coacode { get; set; }
        public int SegmentNbr { get; set; }
        public string SegmentCode { get; set; }
        public int SubSegmentNbr { get; set; }
        public string ValOption { get; set; }
        public string DefaultSegment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
