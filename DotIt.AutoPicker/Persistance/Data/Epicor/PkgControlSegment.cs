﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PkgControlSegment
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PkgControlType { get; set; }
        public string PkgControlIdcode { get; set; }
        public string ControlIdcode { get; set; }
        public int SegmentNum { get; set; }
        public string SegmentDesc { get; set; }
        public string AlphaRangeFrom { get; set; }
        public string AlphaRangeTo { get; set; }
        public string AlphaRangeLastValue { get; set; }
        public long NumericRangeFrom { get; set; }
        public long NumericRangeTo { get; set; }
        public long NumericRangeLastValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int SegmentPosition { get; set; }
        public string SegmentType { get; set; }
        public string SegmentFormat { get; set; }
        public string RolloverTrigger { get; set; }
        public string RolloverAction { get; set; }
        public DateTime? DateLastValue { get; set; }
        public bool IsFixedLength { get; set; }

        public virtual PkgControl PkgControl { get; set; }
    }
}
