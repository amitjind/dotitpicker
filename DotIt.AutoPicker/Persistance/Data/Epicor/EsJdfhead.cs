﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsJdfhead
    {
        public EsJdfhead()
        {
            EsJdfdtl = new HashSet<EsJdfdtl>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string PlanNum { get; set; }
        public string DescriptiveName { get; set; }
        public string JobNum { get; set; }
        public string CustId { get; set; }
        public string CustName { get; set; }
        public string CommentText { get; set; }
        public int? DbgNumOfJdfdtl { get; set; }
        public int? PlanExportToJobLevel { get; set; }
        public decimal? JobQty { get; set; }
        public string EstimationId { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public string UserChar5 { get; set; }
        public string UserChar6 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public DateTime? UserDate5 { get; set; }
        public DateTime? UserDate6 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public decimal? UserDecimal9 { get; set; }
        public decimal? UserDecimal10 { get; set; }
        public decimal? UserDecimal11 { get; set; }
        public decimal? UserDecimal12 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }
        public int? UserInteger5 { get; set; }
        public int? UserInteger6 { get; set; }

        public virtual ICollection<EsJdfdtl> EsJdfdtl { get; set; }
    }
}
