﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsysUserComp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string UserId { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string CurPlant { get; set; }
        public string PlantList { get; set; }
        public string SolutionId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
