﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImesFinishe
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
        public int? Qpos { get; set; }
        public string Plant { get; set; }
        public string FinishId { get; set; }
        public string FinishingUserId { get; set; }
        public string FinishDescription { get; set; }
        public string CustomerDesc { get; set; }
        public string StdType { get; set; }
        public string FinishingType { get; set; }
        public bool? TrueTmp { get; set; }
        public string EstimateId { get; set; }
        public string PartId { get; set; }
        public bool? UseInterpolation { get; set; }
        public bool? IncludeScenario { get; set; }
        public bool? LaborIncludedInStandard { get; set; }
        public decimal? PartialQty { get; set; }
        public decimal? PctOfQty { get; set; }
        public decimal? QtyToFinish { get; set; }
        public int? NumOfMachinePockets { get; set; }
        public int? TotFeedersAndPocketsToAsign { get; set; }
        public int? TotalPocketsWofeedersUsed { get; set; }
        public int? NumFeedersAndPocketsNeeded { get; set; }
        public string NumFeedersAndPocketsOnPass { get; set; }
        public int? NumOfMachineStaticFeeders { get; set; }
        public int? NumOfMachineMoveableFeeders { get; set; }
        public bool? BindFeedersUseFourPp { get; set; }
        public int? TotP2pfeedersToAssign { get; set; }
        public int? TotalstaticFeedersUsed { get; set; }
        public int? TotalMoveableFeedersUsed { get; set; }
        public int? MoveableFeedersInlineRecs { get; set; }
        public string BindMoveableInline { get; set; }
        public int? NumOfPasses { get; set; }
        public int? NumberOutUi { get; set; }
        public bool? IsCutOperation { get; set; }
        public decimal? QtyNumberOut { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
        public string SourceDtlId { get; set; }
        public bool? MatIncluded { get; set; }
        public int? NumOfHelpersMulElement { get; set; }
        public int? NumOfHelpers { get; set; }
        public decimal? SetupPocketsSpoilPct { get; set; }
        public decimal? SetupPiecesSpoil { get; set; }
        public int? InlineSetUpUnits { get; set; }
        public int? TotalSetupPieces { get; set; }
        public decimal? TotalSetupPiecesWithNumOut { get; set; }
        public decimal? ProdSpoilAdjPctSeme { get; set; }
        public decimal? ProdSpoilAdjPctMpieces { get; set; }
        public decimal? ProdSpoilAdjPct { get; set; }
        public decimal? CaliperSpoilAdjPct { get; set; }
        public decimal? PocketsSpoilAdjPct { get; set; }
        public decimal? InlineSpoilAdjPct { get; set; }
        public decimal? TotalSpoilProdAdjPct { get; set; }
        public decimal? BaseProdSpoilPct { get; set; }
        public decimal? TotalSpoilPct { get; set; }
        public string VgorderInStdType { get; set; }
        public string VgorderInPlan { get; set; }
        public string OrderWithinIdentical { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public decimal? Parent1stQtyIn { get; set; }
        public decimal? ValueIfLastMain { get; set; }
        public decimal? QtyOutMain { get; set; }
        public decimal? QtyInMain { get; set; }
        public int? FinishedPages { get; set; }
        public decimal? NumOutxWebFactor { get; set; }
        public decimal? SumLgfactorOrpressToFin { get; set; }
        public decimal? MainRatioToStockShts { get; set; }
        public decimal? ProdUnitRatioToStockSheet { get; set; }
        public decimal? QtyInMainStockShts { get; set; }
        public decimal? QtyOutMainStockShts { get; set; }
        public int? NumberOfSections { get; set; }
        public int? NumberOfSides { get; set; }
        public decimal? NetSheetsSelm { get; set; }
        public decimal? NetRunIncPassMelm { get; set; }
        public decimal? QtyToFinishTotalSelm { get; set; }
        public decimal? QtyToFinishTotalMelm { get; set; }
        public decimal? NetRunLengthAll { get; set; }
        public decimal? TotalProdSpoilPieces { get; set; }
        public decimal? TotalNumProdsIncSpoilgeMe { get; set; }
        public decimal? SpoilPiecesIncNumOut { get; set; }
        public int? FinishSetupIfNotSingle { get; set; }
        public int? FinishingSetupSingle { get; set; }
        public int? FinChildSetupStockShts { get; set; }
        public decimal? FinishSpoilIfNotsingle { get; set; }
        public decimal? FinishingSpoilSingle { get; set; }
        public decimal? FinChildSpoilStockShts { get; set; }
        public decimal? ChildWasteStockShts { get; set; }
        public decimal? UnitPerMpiecesIfPieces { get; set; }
        public decimal? UnitPerMpiecesIfWeight { get; set; }
        public decimal? UnitPerMpiecesIfCalLift { get; set; }
        public decimal? UnitPerMpiecesIfVolume { get; set; }
        public decimal? TotalUnitPerMpieces { get; set; }
        public decimal? MpiecesProdUnitsNotRounded { get; set; }
        public decimal? MpiecesProdUnitsRounded { get; set; }
        public decimal? MpiecesTotalUnits { get; set; }
        public decimal? MpiecesProdAndSpoil { get; set; }
        public decimal? MpiecesSpoilUnits { get; set; }
        public int? MpiecesSetupUnits { get; set; }
        public decimal? MpiecesSpoilUnitsRounded { get; set; }
        public decimal? NumOfMatProdUnitSeme { get; set; }
        public int? NumOfMatProdUnitFlatRate { get; set; }
        public int? NumOfMatProdUnitMpieces { get; set; }
        public decimal? TmpTotalNumOfProdUnit { get; set; }
        public int? TotalNumOfProdUnit { get; set; }
        public decimal? ProdLengthLaborAdjSelmel { get; set; }
        public decimal? ProdLengthLaborAdjMpieces { get; set; }
        public decimal? ProdLengthLaborAdjPct { get; set; }
        public decimal? NumOfPocketsLaborAdjPct { get; set; }
        public decimal? CaliperLaborAdjPct { get; set; }
        public decimal? InlineLaborAdjPct { get; set; }
        public decimal? TotalLaborAdj { get; set; }
        public decimal? MaxFinishingspeed { get; set; }
        public decimal? MinFinishingSpeed { get; set; }
        public decimal? FinStanardSpeed { get; set; }
        public decimal? CalcSpeed { get; set; }
        public decimal? FinalSpeedMesemp { get; set; }
        public decimal? ProdHrFlatRate { get; set; }
        public decimal? ProdHrSelement { get; set; }
        public decimal? ProdHrMelement { get; set; }
        public decimal? ProdHrMpieces { get; set; }
        public decimal? TmpPodHrAllType { get; set; }
        public decimal? MinProdHr { get; set; }
        public decimal? ProdHr { get; set; }
        public decimal? MarginalProdHr { get; set; }
        public decimal? BaseSetupHres { get; set; }
        public decimal? InlineSetupHres { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? CleanupHr { get; set; }
        public decimal? TotalMachineFinishHr { get; set; }
        public decimal? VolumePer1Unit { get; set; }
        public decimal? WeightPer1Unit { get; set; }
        public decimal? CalliperPer1Unit { get; set; }
        public decimal? WeightPer1ProdUnit { get; set; }
        public decimal? VolumePer1ProdUnit { get; set; }
        public decimal? CaliperPer1ProdUnit { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public decimal? MatWidth { get; set; }
        public decimal? MatLength { get; set; }
        public decimal? MatArea { get; set; }
        public string MatCalcBy { get; set; }
        public string MatCalcByUitmp { get; set; }
        public decimal? PlanEstCostPeProdit { get; set; }
        public string MatUom { get; set; }
        public decimal? NoOfMatUnits { get; set; }
        public decimal? MatQtyPerFpieces { get; set; }
        public decimal? MatQtyPerFprod { get; set; }
        public decimal? MatQtyPerJob { get; set; }
        public decimal? MatQty { get; set; }
        public bool? IsOriginalPart { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string Uom { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? Iumcost { get; set; }
        public string CostSourceTexts { get; set; }
        public int? OptionPosition { get; set; }
        public string MfgItemName { get; set; }
        public string ProdUnit { get; set; }
        public string FinishingMeasuredBy { get; set; }
        public decimal? FinishingUnitSize { get; set; }
        public decimal? LaborMarkup { get; set; }
        public decimal? MatMarkup { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartIdui { get; set; }
        public string MatPartDesc { get; set; }
        public bool? PurchaseDirect { get; set; }
        public string ProdOperationId { get; set; }
        public string ProdOperationDesc { get; set; }
        public string WashupOperationId { get; set; }
        public string WashupOperationDesc { get; set; }
        public string OpComment { get; set; }
        public string OpWashComment { get; set; }
        public string AddFixedToComment { get; set; }
        public string MatBlname { get; set; }
        public string OperationBlname { get; set; }
        public string OpDtlBlname { get; set; }
        public string StandardDescription { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgnameAndType { get; set; }
        public string VgandMat { get; set; }
        public string ShowInRoutingOrMaterial { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public decimal? FinSheetToPress { get; set; }
        public decimal? FinSheetToStock { get; set; }
        public string BindingStyleTmp { get; set; }
        public int? BindingStyle { get; set; }
        public int? IsBinding { get; set; }
        public int? IsPerfectBinding { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public bool? Subcontracting { get; set; }
        public bool? SubcIsMatInPartsTbl { get; set; }
        public bool? SubcPrListPriority { get; set; }
        public bool? SubcPriceBexistForPart { get; set; }
        public string SubcBrowsePbui { get; set; }
        public decimal? SubcUomcostPlist { get; set; }
        public decimal? SubcUomcostNoPlist { get; set; }
        public int? SubcVendorNum { get; set; }
        public string SubcVendorId { get; set; }
        public string SubcVendorName { get; set; }
        public string SubcMatPartNum { get; set; }
        public string SubcMatPartDesc { get; set; }
        public string SubcPartUom { get; set; }
        public decimal? EstUomconvFactorToBase { get; set; }
        public decimal? PlistUmconvFactorToEstUm { get; set; }
        public int? SubcDaysOut { get; set; }
        public string SubcVendorContact { get; set; }
        public decimal? SubcEffectiveUnitCost { get; set; }
        public string SubcCostSourceTexts { get; set; }
        public int? SubcPlistPricePer { get; set; }
        public string HelperSchedResourceId { get; set; }
        public string TopLevelUserId { get; set; }
        public string OpAnalysisCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public string OpAnalysisCodeWash { get; set; }
        public string OpAnalysisCodeDescWash { get; set; }
        public string StdPlantId { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public int? NumOfInlines { get; set; }
        public bool? E2jcreateOpInJob { get; set; }
        public int? NumberOutApp { get; set; }
        public int? FinishDescriptionOvrd { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? PartialQtyOvrd { get; set; }
        public int? PctOfQtyOvrd { get; set; }
        public int? QtyToFinishOvrd { get; set; }
        public int? NumOfMachinePocketsOvrd { get; set; }
        public int? TotFeedersAndPocketsToAsignOvrd { get; set; }
        public int? TotalPocketsWofeedersUsedOvrd { get; set; }
        public int? NumFeedersAndPocketsNeededOvrd { get; set; }
        public int? NumOfMachineStaticFeedersOvrd { get; set; }
        public int? NumOfMachineMoveableFeedersOvrd { get; set; }
        public int? BindFeedersUseFourPpOvrd { get; set; }
        public int? TotP2pfeedersToAssignOvrd { get; set; }
        public int? TotalstaticFeedersUsedOvrd { get; set; }
        public int? TotalMoveableFeedersUsedOvrd { get; set; }
        public int? MoveableFeedersInlineRecsOvrd { get; set; }
        public int? NumOfPassesOvrd { get; set; }
        public int? NumberOutUiOvrd { get; set; }
        public int? NumOfHelpersOvrd { get; set; }
        public int? SetupPocketsSpoilPctOvrd { get; set; }
        public int? TotalSetupPiecesOvrd { get; set; }
        public int? TotalSpoilPctOvrd { get; set; }
        public int? VgorderInStdTypeOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
        public int? MainRatioToStockShtsOvrd { get; set; }
        public int? NumberOfSectionsOvrd { get; set; }
        public int? NumberOfSidesOvrd { get; set; }
        public int? NetSheetsSelmOvrd { get; set; }
        public int? NetRunIncPassMelmOvrd { get; set; }
        public int? TotalProdSpoilPiecesOvrd { get; set; }
        public int? ChildWasteStockShtsOvrd { get; set; }
        public int? TmpTotalNumOfProdUnitOvrd { get; set; }
        public int? TotalNumOfProdUnitOvrd { get; set; }
        public int? TotalLaborAdjOvrd { get; set; }
        public int? FinalSpeedMesempOvrd { get; set; }
        public int? ProdHrOvrd { get; set; }
        public int? SetupHrOvrd { get; set; }
        public int? CleanupHrOvrd { get; set; }
        public int? VolumePer1UnitOvrd { get; set; }
        public int? WeightPer1UnitOvrd { get; set; }
        public int? CalliperPer1UnitOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? MatWidthOvrd { get; set; }
        public int? MatLengthOvrd { get; set; }
        public int? PlanEstCostPeProditSttc { get; set; }
        public int? NoOfMatUnitsOvrd { get; set; }
        public int? MatQtyOvrd { get; set; }
        public int? UomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? ProdUnitOvrd { get; set; }
        public int? FinishingMeasuredByOvrd { get; set; }
        public int? FinishingUnitSizeOvrd { get; set; }
        public int? MatPartNumOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? PurchaseDirectOvrd { get; set; }
        public int? OpCommentOvrd { get; set; }
        public int? OpWashCommentOvrd { get; set; }
        public int? StandardDescriptionOvrd { get; set; }
        public int? FinSheetToStockOvrd { get; set; }
        public int? SubcPrListPriorityOvrd { get; set; }
        public int? SubcUomcostPlistOvrd { get; set; }
        public int? SubcUomcostNoPlistOvrd { get; set; }
        public int? SubcVendorNumOvrd { get; set; }
        public int? SubcMatPartNumOvrd { get; set; }
        public int? SubcMatPartDescOvrd { get; set; }
        public int? SubcDaysOutOvrd { get; set; }
        public int? SubcVendorContactOvrd { get; set; }
        public int? SubcEffectiveUnitCostOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeDescOvrd { get; set; }
        public int? OpAnalysisCodeWashOvrd { get; set; }
        public int? OpAnalysisCodeDescWashOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public decimal? FinPcWidthForMin { get; set; }
        public decimal? FinPcWidthForMax { get; set; }
        public decimal? FinPcLengthForMin { get; set; }
        public decimal? FinPcLengthForMax { get; set; }
        public string EstimateUserId { get; set; }
        public decimal? SpineXfactor { get; set; }
        public int? SpineXfactorOvrd { get; set; }
        public decimal? SpineAddFctr { get; set; }
        public int? SpineAddFctrOvrd { get; set; }
        public decimal? SpineRndFctr { get; set; }
        public int? SpineRndFctrOvrd { get; set; }
        public decimal? CaliperCaseTotalAdjusts { get; set; }
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
        public decimal? TotalHelperCost { get; set; }
        public decimal? InlineSetupAdjPct { get; set; }
        public int? InlineSetupAdjPctOvrd { get; set; }
        public decimal? WidthSpoilAdjPct { get; set; }
        public decimal? LengthSpoilAdjPct { get; set; }
        public decimal? WidthLaborAdjPct { get; set; }
        public decimal? LengthLaborAdjPct { get; set; }
        public decimal? FinPieceWidthForAdj { get; set; }
        public decimal? FinPieceLengthForAdj { get; set; }
        public decimal? BookTotalWidth { get; set; }
        public decimal? BookTotalLength { get; set; }
        public decimal? AdjustedSpineCaliper { get; set; }
        public int? BookTotalWidthOvrd { get; set; }
        public int? BookTotalLengthOvrd { get; set; }
        public int? AdjustedSpineCaliperOvrd { get; set; }
    }
}
