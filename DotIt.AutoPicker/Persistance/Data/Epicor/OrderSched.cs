﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class OrderSched
    {
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int PaySeq { get; set; }
        public int PayDays { get; set; }
        public decimal PayPercent { get; set; }
        public decimal PayAmount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DocPayAmount { get; set; }
        public decimal Rpt1PayAmount { get; set; }
        public decimal Rpt2PayAmount { get; set; }
        public decimal Rpt3PayAmount { get; set; }

        public virtual OrderHed OrderHed { get; set; }
    }
}
