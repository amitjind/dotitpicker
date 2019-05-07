﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImesInlinee
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string Plant { get; set; }
        public string InlineId { get; set; }
        public string InlineUserId { get; set; }
        public string InlineDesc { get; set; }
        public string CustomerDesc { get; set; }
        public string PressErecId { get; set; }
        public string PressRecId { get; set; }
        public string FoldElgrecId { get; set; }
        public string PostCutElgrecId { get; set; }
        public string FinishErecId { get; set; }
        public string PreCutErecId { get; set; }
        public string FatherRecId { get; set; }
        public string ParentStdid { get; set; }
        public string EstimateId { get; set; }
        public bool? IncludeScenario { get; set; }
        public string PartId { get; set; }
        public string SourceDesc { get; set; }
        public string ProdOperationId { get; set; }
        public string SourceOperationDesc { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public bool? IncludeLaborInStandard { get; set; }
        public string ResGroupId { get; set; }
        public decimal? SetupHr { get; set; }
        public int? Setupunits { get; set; }
        public decimal? LaborAdjPct { get; set; }
        public decimal? SpoilAdjPct { get; set; }
        public decimal? MaxSpeedTemp { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartDesc { get; set; }
        public string MatMfgComment { get; set; }
        public string MatPurchComment { get; set; }
        public bool? PurchaseDirect { get; set; }
        public string MatPartIdui { get; set; }
        public string HelperResGroupId { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string MatMarkupPct { get; set; }
        public bool? MatIncluded { get; set; }
        public decimal? SheetWidth { get; set; }
        public decimal? CalcSheetWidth { get; set; }
        public decimal? SheetLength { get; set; }
        public decimal? CalcSheetLength { get; set; }
        public decimal? ProductThickness { get; set; }
        public decimal? CalcProductThickness { get; set; }
        public decimal? ProductWeight { get; set; }
        public decimal? CalcProductWeight { get; set; }
        public decimal? FpieceWidth { get; set; }
        public decimal? CalcFpieceWidth { get; set; }
        public decimal? FpieceLength { get; set; }
        public decimal? CalcFpieceLength { get; set; }
        public decimal? FpieceOpWidth { get; set; }
        public decimal? CalcFpieceOpWidth { get; set; }
        public decimal? FpieceOpLength { get; set; }
        public decimal? CalcFpieceOpLength { get; set; }
        public decimal? AllMatSizeCalc { get; set; }
        public int? RunQtyInFoldE { get; set; }
        public decimal? NetMatQtyPerFoldedLy { get; set; }
        public decimal? MatQtyInFoldFirstLy { get; set; }
        public decimal? MatQtyInFoldFolLy { get; set; }
        public int? RunQtyInPressE { get; set; }
        public decimal? RunQtyInPostCutE { get; set; }
        public decimal? RunQtyInPretCutE { get; set; }
        public int? RunQtyInFinishE { get; set; }
        public decimal? AllProdQtyCalc { get; set; }
        public decimal? CalcAllProdQtyCalc { get; set; }
        public decimal? BaseMatQty { get; set; }
        public decimal? TotalMatMultiFactor { get; set; }
        public decimal? MatQty { get; set; }
        public decimal? MatQtyFirstLy { get; set; }
        public decimal? MatQtyFolLy { get; set; }
        public decimal? PlanEstCostPeProdit { get; set; }
        public bool? IsOriginalPart { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string Uom { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? Iumcost { get; set; }
        public string CostSourceTexts { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgorderInPlan { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public string ParentSyncNumber { get; set; }
        public string ParentStdUserId { get; set; }
        public bool? IsSourceSetUp { get; set; }
        public string ShowInRoutingOrMaterial { get; set; }
        public string OpDtlBlnamePrefix { get; set; }
        public string RecIdtext { get; set; }
        public string OpDtlBlnameInline { get; set; }
        public string MatBlnameTop { get; set; }
        public string MatBlnameLg { get; set; }
        public string MatBlname1st { get; set; }
        public string MatBlnameFoll { get; set; }
        public string RelOperTop { get; set; }
        public string RelOperLglyt { get; set; }
        public string RelOperErecIdtop { get; set; }
        public string RelOperErecIdlg { get; set; }
        public string RelatedPressOper { get; set; }
        public string RelatedPressOperationId { get; set; }
        public string RelOpBlpressTop { get; set; }
        public string RelOpBlpressLg { get; set; }
        public string RelOpBlpressLty { get; set; }
        public string RelOpBlfoldLg { get; set; }
        public string RelOpBlfoldLty { get; set; }
        public string RelOpBlfoldFolLy { get; set; }
        public string RelOpBlpostCutLg { get; set; }
        public string RelOpBlpostCutLty { get; set; }
        public string RelOpBlfinish { get; set; }
        public string RelOpBlpreCut { get; set; }
        public string RelOpBltop { get; set; }
        public string RelOpBllg { get; set; }
        public string RelOpBllyt { get; set; }
        public string RelOpBlfolLyt { get; set; }
        public string TmpRelBlopTop { get; set; }
        public string AssemblyHlgtmp1 { get; set; }
        public string AssemblyHlgtmp2 { get; set; }
        public string AssemblyHlgtmp3 { get; set; }
        public string AssemblyHierarchyLg { get; set; }
        public string AssemblyHierarchyLyt { get; set; }
        public string ImpSummary { get; set; }
        public string LytSummary { get; set; }
        public int? Lgnumber { get; set; }
        public string LgnumberUi { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public string InlineComments { get; set; }
        public decimal? StandardType { get; set; }
        public string TopLevelUserId { get; set; }
        public int? TmpLgnumber { get; set; }
        public string MatAnalysisCode { get; set; }
        public string MatAnalysisCodeDesc { get; set; }
        public string StdPlantId { get; set; }
        public bool? PrListPriority { get; set; }
        public decimal? EstUomconvFactorToBase { get; set; }
        public decimal? PlistUmconvFactorToEstUm { get; set; }
        public bool? PriceBexistForPart { get; set; }
        public decimal? UomcostPlist { get; set; }
        public decimal? UomcostPlistInEstUom { get; set; }
        public string BrowsePriceBreaks { get; set; }
        public int? PlistPricePer { get; set; }
        public string StdType { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public bool? MakeDirectUi { get; set; }
        public string MarkupLevels { get; set; }
        public int? CountMe { get; set; }
        public bool? MakeDirectApp { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? SetupHrOvrd { get; set; }
        public int? SetupunitsOvrd { get; set; }
        public int? LaborAdjPctOvrd { get; set; }
        public int? SpoilAdjPctOvrd { get; set; }
        public int? MatPartNumOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? MatMfgCommentOvrd { get; set; }
        public int? MatPurchCommentOvrd { get; set; }
        public int? PurchaseDirectOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? BaseMatQtyOvrd { get; set; }
        public int? MatQtyOvrd { get; set; }
        public int? PlanEstCostPeProditSttc { get; set; }
        public int? UomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? MatAnalysisCodeDescOvrd { get; set; }
        public int? PrListPriorityOvrd { get; set; }
        public int? MakeDirectUiOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string EstimateUserId { get; set; }
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
        public decimal? SetupCrewSize { get; set; }
        public int? SetupCrewSizeOvrd { get; set; }
        public decimal? ProdCrewSize { get; set; }
        public int? ProdCrewSizeOvrd { get; set; }
        public decimal? TotalHelperCost { get; set; }
        public decimal? SetupAdjPct { get; set; }
        public int? SetupAdjPctOvrd { get; set; }
        public decimal? HelperSetupCrewSize { get; set; }
        public decimal? HelperProdCrewSize { get; set; }
    }
}