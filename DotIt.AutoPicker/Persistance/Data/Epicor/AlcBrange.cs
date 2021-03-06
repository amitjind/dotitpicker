﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlcBrange
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public int CycleUid { get; set; }
        public int SegmentNbr { get; set; }
        public string BookId { get; set; }
        public string Coacode { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
