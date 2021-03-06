﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsFolding
    {
        public EsFolding()
        {
            EsFoldingelg = new HashSet<EsFoldingelg>();
            EsInlinefold = new HashSet<EsInlinefold>();
            EsPartsbf = new HashSet<EsPartsbf>();
            EsPidefaultssbf = new HashSet<EsPidefaultssbf>();
            EsScenariodefaultsdtl = new HashSet<EsScenariodefaultsdtl>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string FoldingUserId { get; set; }
        public bool? IsFolding { get; set; }
        public string StdType { get; set; }
        public bool? TempTrue { get; set; }
        public string StdTypeUserId { get; set; }
        public string FoldingDesc { get; set; }
        public string CustomerDesc { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public bool? Inactive { get; set; }
        public string OperationId { get; set; }
        public string OperationDesc { get; set; }
        public string DefaultSpecCat { get; set; }
        public string Cfdlabor { get; set; }
        public string MarkupLevels { get; set; }
        public string MarkupPercents { get; set; }
        public decimal? MinSheetWidth { get; set; }
        public decimal? MaxSheetWidth { get; set; }
        public decimal? MinSheetLength { get; set; }
        public decimal? MaxSheetLength { get; set; }
        public bool? ValidMinWsmallMax { get; set; }
        public bool? ValidMinLsmallMax { get; set; }
        public decimal? BaseProdSpoilPct { get; set; }
        public decimal? BaseProdSpoilPctUi { get; set; }
        public string CaliperBreak { get; set; }
        public string CaliperSpoilAdjPct { get; set; }
        public string CaliperLaborAdjPct { get; set; }
        public string ProdUnit { get; set; }
        public int? BaseSetUpSheets { get; set; }
        public bool? IsCutting { get; set; }
        public decimal? BaseSetUpHr { get; set; }
        public decimal? MinProdSpeed { get; set; }
        public decimal? AverageProdSpeed { get; set; }
        public decimal? MaxProdSpeed { get; set; }
        public bool? ValidMinSmallAvLenShtHr { get; set; }
        public bool? ValidMaxLargeAvLenShtHr { get; set; }
        public decimal? RunGap { get; set; }
        public decimal? CalipertoAddScoreWheel { get; set; }
        public string ProdLengthSpoilAdjPct { get; set; }
        public string ProdLengthLaborAdjPct { get; set; }
        public string ProdLengthBreak { get; set; }
        public decimal? AddlParallelFoldHr { get; set; }
        public decimal? AddlRightAngleFoldHr { get; set; }
        public decimal? AddlPerfScoreFoldHr { get; set; }
        public int? AddlParallelFoldShts { get; set; }
        public int? AddlRightAngleFoldShts { get; set; }
        public int? AddlPerfScoreFoldShts { get; set; }
        public decimal? FirstParallelFoldHr { get; set; }
        public decimal? FirstRightAngleFoldHr { get; set; }
        public decimal? FirstPerfScoreFoldHr { get; set; }
        public int? FirstParallelFoldShts { get; set; }
        public int? FirstRightAngleFoldShts { get; set; }
        public int? FirstPerfScoreFoldShts { get; set; }
        public decimal? AddlParallelSpoilAdjPct { get; set; }
        public decimal? AddlParallelLaborAdjPct { get; set; }
        public decimal? FirstParallelLaborAdjPct { get; set; }
        public decimal? FirstRtAngleSpoilAdjPct { get; set; }
        public decimal? FirstRtAngleLabAdjPct { get; set; }
        public decimal? AddlRtAngleSpoilAdjPct { get; set; }
        public decimal? AddlRightAngleLaborAdjPct { get; set; }
        public decimal? FirstPerfScoreLaborAdjPct { get; set; }
        public decimal? FirstPerfScoreSpoilAdjPct { get; set; }
        public decimal? AddlPerfScoreSpoilAdjPct { get; set; }
        public decimal? AddlPerfScoreLaborAdjPct { get; set; }
        public decimal? FirstParallelSpoilAdjPct { get; set; }
        public int? RecordNumber { get; set; }
        public decimal? FirstGluerHr { get; set; }
        public decimal? AddlGluerHr { get; set; }
        public int? FirstGluerShts { get; set; }
        public int? AddlGluerShts { get; set; }
        public decimal? FirstGluerSpoilAdjPct { get; set; }
        public decimal? AddlGluerSpoilAdjPct { get; set; }
        public decimal? FirstGluerLaborAdjPct { get; set; }
        public decimal? AddlGluerLaborAdjPct { get; set; }
        public string WidthBreak { get; set; }
        public string WidthLaborAdjPct { get; set; }
        public string WidthSpoilAdjPct { get; set; }
        public string LengthBreak { get; set; }
        public string LengthLaborAdjPct { get; set; }
        public string LengthSpoilAdjPct { get; set; }
        public string GroupId { get; set; }
        public string GroupUserId { get; set; }
        public string EstimationDisplayGroup { get; set; }
        public bool? GroupToViewingGroup { get; set; }
        public string GroupOrderInStdType { get; set; }
        public string StdTypeOrderInMfgPlan { get; set; }
        public string OrderInGroup { get; set; }
        public decimal? MinCaliper { get; set; }
        public decimal? MaxCaliper { get; set; }
        public bool? ValidMinCaliperSmallMax { get; set; }
        public string UirecIdentifier { get; set; }
        public bool? IsSchedResExist { get; set; }
        public bool? AllowInCurPlant { get; set; }
        public string SubcPartNum { get; set; }
        public bool? Subcontracting { get; set; }
        public bool? SubcIsMatInPartsTbl { get; set; }
        public string SubcPartDesc { get; set; }
        public string SubcPartUom { get; set; }
        public bool? IsZeroSubcUomfactorToBase { get; set; }
        public int? SubcDaysOut { get; set; }
        public int? SubcVendorNum { get; set; }
        public string SubcVendorId { get; set; }
        public int? SubcCostSourceSelected { get; set; }
        public string SubcUomoptionsCombo { get; set; }
        public decimal? SubcCostPerEach { get; set; }
        public bool? SubcPrListPriority { get; set; }
        public bool? IsInline { get; set; }
        public string OpAnalysisCode { get; set; }
        public bool? OpIsMissingAnalysCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public bool? IsInlineAndFolding { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? SubcPartDescOvrd { get; set; }
        public int? SubcPartUomOvrd { get; set; }
        public int? SubcDaysOutOvrd { get; set; }
        public int? SubcVendorNumOvrd { get; set; }
        public int? SubcCostPerEachOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string MeasureSpeedByUom { get; set; }
        public string MeasureSpeedPerUom { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool? ShowInRfq { get; set; }
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
        public virtual ICollection<EsFoldingelg> EsFoldingelg { get; set; }
        public virtual ICollection<EsInlinefold> EsInlinefold { get; set; }
        public virtual ICollection<EsPartsbf> EsPartsbf { get; set; }
        public virtual ICollection<EsPidefaultssbf> EsPidefaultssbf { get; set; }
        public virtual ICollection<EsScenariodefaultsdtl> EsScenariodefaultsdtl { get; set; }
    }
}
