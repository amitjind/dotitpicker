﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class OpText
    {
        public string Company { get; set; }
        public string OpTextId { get; set; }
        public string Description { get; set; }
        public string InspectLines { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
