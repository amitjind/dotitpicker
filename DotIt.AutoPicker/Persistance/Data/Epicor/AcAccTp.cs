﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcAccTp
    {
        public string Company { get; set; }
        public string AccTpCd { get; set; }
        public string AccTpDesc { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}