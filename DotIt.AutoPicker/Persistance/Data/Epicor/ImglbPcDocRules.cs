﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPcDocRules
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string ExtCompanyId { get; set; }
        public int RuleSeq { get; set; }
        public string RuleString { get; set; }
        public string RuleType { get; set; }
        public string CalcName { get; set; }
        public string CalcDataType { get; set; }
        public string DbField { get; set; }
        public string DbTable { get; set; }
        public string SourceDbrecid { get; set; }
        public string Comments { get; set; }
        public string RuleExpr { get; set; }
        public int ProcessSeq { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public string ConfigId { get; set; }
        public string Lvalue { get; set; }
        public string CompareOpr { get; set; }
        public string Rvalue { get; set; }
        public string RvalueType { get; set; }
        public string Description { get; set; }
        public string ExtCompanyList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
