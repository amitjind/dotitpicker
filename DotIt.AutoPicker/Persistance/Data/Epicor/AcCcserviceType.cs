﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCcserviceType
    {
        public string Company { get; set; }
        public string ServiceTypeCd { get; set; }
        public string ServiceTypeDesc { get; set; }
        public string ServiceTypeBillDesc { get; set; }
        public string TaxCd { get; set; }
        public string ExpenditureType { get; set; }
        public string Category { get; set; }
        public string CallCode { get; set; }
        public string OpCode { get; set; }
        public bool NonBillable { get; set; }
        public bool Inactive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
