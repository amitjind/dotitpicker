﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PlantConfAbc
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string Abccode { get; set; }
        public bool OvrrideCountFreq { get; set; }
        public int CountFreq { get; set; }
        public bool ExcludeFromCc { get; set; }
        public decimal StockValPcnt { get; set; }
        public decimal PcntTolerance { get; set; }
        public bool CalcPcnt { get; set; }
        public bool CalcQty { get; set; }
        public bool CalcValue { get; set; }
        public bool OvrrideStockValPcnt { get; set; }
        public decimal QtyTolerance { get; set; }
        public decimal ValueTolerance { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
