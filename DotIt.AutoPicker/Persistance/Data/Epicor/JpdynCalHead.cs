﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JpdynCalHead
    {
        public string Company { get; set; }
        public string DynCalId { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
