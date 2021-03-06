﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LocalType
    {
        public string Company { get; set; }
        public string LocalName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
