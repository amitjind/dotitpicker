﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPcFunctionParam
    {
        public string Company { get; set; }
        public string FunctionName { get; set; }
        public string ParameterName { get; set; }
        public string DefaultValue { get; set; }
        public string Modifier { get; set; }
        public string ParamType { get; set; }
        public string ConfigId { get; set; }
        public int ParamSeq { get; set; }
        public string GlbCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
