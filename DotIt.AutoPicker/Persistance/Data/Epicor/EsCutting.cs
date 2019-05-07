﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsCutting
    {
        public EsCutting()
        {
            EsInlinecut = new HashSet<EsInlinecut>();
            EsPostcutelg = new HashSet<EsPostcutelg>();
            EsPrecute = new HashSet<EsPrecute>();
            EsScenariodefaultsdtlPostpressCutter = new HashSet<EsScenariodefaultsdtl>();
            EsScenariodefaultsdtlPrepressCutter = new HashSet<EsScenariodefaultsdtl>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string CuttingUserId { get; set; }
        public string StdType { get; set; }
        public string StdTypeUserId { get; set; }
        public string CuttingDesc { get; set; }
        public string CustomerDesc { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public int? SetupSheets { get; set; }
        public bool? Inactive { get; set; }
        public string OperationId { get; set; }
        public string OperationDesc { get; set; }
        public string MarkupLevels { get; set; }
        public string MarkupPercents { get; set; }
        public decimal? MaxSheetLength { get; set; }
        public decimal? MaxSheetWidth { get; set; }
        public decimal? BaseProdSpoilPctUi { get; set; }
        public decimal? BaseProdSpoilPct { get; set; }
        public string CaliperBreak { get; set; }
        public string CaliperSpoilAdjPct { get; set; }
        public string CaliperLaborAdjPct { get; set; }
        public string LiftsBasedOn { get; set; }
        public decimal? AvgLiftHeight { get; set; }
        public decimal? AvgWeightPerLift { get; set; }
        public decimal? MaxLiftHeight { get; set; }
        public decimal? MaxWeightPerLift { get; set; }
        public string CutBreaks { get; set; }
        public string SetupHr { get; set; }
        public string LiftsPerHr { get; set; }
        public bool? InvalidLiftsPerHr { get; set; }
        public string GroupId { get; set; }
        public string GroupUserId { get; set; }
        public string EstimationDisplayGroup { get; set; }
        public bool? GroupToViewingGroup { get; set; }
        public string GroupOrderInStdType { get; set; }
        public string StdTypeOrderInMfgPlan { get; set; }
        public string OrderInGroup { get; set; }
        public bool? UseCutterAsTrimer { get; set; }
        public decimal? UseCutterAsTrimmerThreshold { get; set; }
        public bool? IsValidCutterAsTrimmer { get; set; }
        public bool? IsSchedResExist { get; set; }
        public bool? AllowInCurPlant { get; set; }
        public string UirecIdentifier { get; set; }
        public string OpAnalysisCode { get; set; }
        public bool? OpIsMissingAnalysCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public bool? TmpTrue { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
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

        public virtual EsGroups Group { get; set; }
        public virtual EsStdtype StdTypeNavigation { get; set; }
        public virtual ICollection<EsInlinecut> EsInlinecut { get; set; }
        public virtual ICollection<EsPostcutelg> EsPostcutelg { get; set; }
        public virtual ICollection<EsPrecute> EsPrecute { get; set; }
        public virtual ICollection<EsScenariodefaultsdtl> EsScenariodefaultsdtlPostpressCutter { get; set; }
        public virtual ICollection<EsScenariodefaultsdtl> EsScenariodefaultsdtlPrepressCutter { get; set; }
    }
}