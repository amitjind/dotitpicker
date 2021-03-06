﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QuerySubQuery
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Seq { get; set; }
        public bool IsUnion { get; set; }
        public string LeftP { get; set; }
        public string RightP { get; set; }
        public string SelectListClause { get; set; }
        public decimal TopRowExpr { get; set; }
        public bool TopInPercent { get; set; }
        public bool TopWithTies { get; set; }
        public string SelectOption { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string OrderByOffSet { get; set; }
        public string OrderByFetch { get; set; }
    }
}
