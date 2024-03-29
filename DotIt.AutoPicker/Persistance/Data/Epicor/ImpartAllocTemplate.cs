﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpartAllocTemplate
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AllocTemplateId { get; set; }
        public string AllocTemplateDesc { get; set; }
        public string AllocType { get; set; }
        public string WarehouseCode { get; set; }
        public string DemandType { get; set; }
        public string ZoneId { get; set; }
        public string SearchSort { get; set; }
        public string BinType { get; set; }
        public string BinNumFirstOption { get; set; }
        public string DistributionType { get; set; }
        public string WhseGroupCode { get; set; }
        public int TransPriority { get; set; }
        public bool CrossDocking { get; set; }
        public bool OnHold { get; set; }
        public bool MultiplePartsPerBin { get; set; }
        public string PackStation { get; set; }
        public string BinNumProductionIn { get; set; }
        public string ForwardStageGroup { get; set; }
        public string WarehouseCodeForwardStage { get; set; }
        public string EmpId { get; set; }
        public string AssignEmpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string WhseDestWarehouseCode { get; set; }
        public bool ReleaseToPicking { get; set; }
    }
}
