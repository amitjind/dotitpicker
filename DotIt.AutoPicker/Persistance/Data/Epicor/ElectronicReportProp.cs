﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ElectronicReportProp
    {
        public string Company { get; set; }
        public int EftheadUid { get; set; }
        public int EftpropUid { get; set; }
        public string PropValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
