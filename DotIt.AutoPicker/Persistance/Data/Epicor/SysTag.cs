﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysTag
    {
        public string Company { get; set; }
        public string ForeignTableName { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string Tag { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsShared { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
