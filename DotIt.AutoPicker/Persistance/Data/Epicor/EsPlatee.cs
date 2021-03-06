﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsPlatee
    {
        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public int? Qpos { get; set; }
        public string PlateIdapp { get; set; }
        public string PlateId { get; set; }
        public string PlateUserId { get; set; }
        public string PlateDescription { get; set; }
        public string CustomerDesc { get; set; }
        public string Plant { get; set; }
        public string StdType { get; set; }
        public bool? TrueTmp { get; set; }
        public string EstimateId { get; set; }
        public string PartId { get; set; }
        public bool? IncludeScenario { get; set; }
        public string PlateStatus { get; set; }
        public int? NetPlates { get; set; }
        public int? NetStandingPlatesUi { get; set; }
        public int? NetNewPlates { get; set; }
        public int? NewPlatesChangesUi { get; set; }
        public int? Wearoutreplacement { get; set; }
        public int? TotalPlateReplacements { get; set; }
        public int? TotalNewplatesNeeded { get; set; }
        public int? TotalNewPlateBurns { get; set; }
        public int? WearoutPlateBurns { get; set; }
        public decimal? LaborAdjUi { get; set; }
        public decimal? SetupHrPerLyt { get; set; }
        public decimal? SetupHrPerPlate { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? BurnHr { get; set; }
        public decimal? TotalPlatingHr { get; set; }
        public bool? BasedOnSqUnits { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Area { get; set; }
        public decimal? TotalUnitsOfMeasure { get; set; }
        public bool? IsOriginalPart { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string Uom { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? Iumcost { get; set; }
        public string CostSourceTexts { get; set; }
        public bool? LaborIncluded { get; set; }
        public bool? MatIncluded { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartIdui { get; set; }
        public string PlateSummary { get; set; }
        public string MatPartDesc { get; set; }
        public string MatMfgComment { get; set; }
        public string MatPurchComment { get; set; }
        public bool? PurchaseDirect { get; set; }
        public string MatPartUom { get; set; }
        public string ProdOperationId { get; set; }
        public string ProdOperationDesc { get; set; }
        public string OpComment { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public bool? Subcontracting { get; set; }
        public bool? SubcIsMatInPartsTbl { get; set; }
        public bool? SubcPrListPriority { get; set; }
        public string SubcMatPartNum { get; set; }
        public string SubcMatPartDesc { get; set; }
        public string SubcPartUom { get; set; }
        public decimal? EstUomconvFactorToBase { get; set; }
        public decimal? PlistUmconvFactorToEstUm { get; set; }
        public int? SubcVendorNum { get; set; }
        public string SubcVendorId { get; set; }
        public string SubcVendorName { get; set; }
        public string SubcVendorContact { get; set; }
        public bool? SubcPriceBexistForPart { get; set; }
        public string SubcBrowsePbui { get; set; }
        public decimal? SubcUomcostPlist { get; set; }
        public decimal? SubcUomcostNoPlist { get; set; }
        public int? SubcDaysOut { get; set; }
        public string SubcCostSourceTexts { get; set; }
        public int? SubcPlistPricePer { get; set; }
        public decimal? CostPerUnitabove { get; set; }
        public int? MaxImpressions { get; set; }
        public decimal? LaborMarkup { get; set; }
        public string MatMarkup { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgorderInStdType { get; set; }
        public string VgorderInPlan { get; set; }
        public string OrderWithinIdentical { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public string ShowInRoutingOrMaterial { get; set; }
        public string PressName { get; set; }
        public string MatBlname { get; set; }
        public string OperationBlname { get; set; }
        public string OpDtlBlname { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public string OperCountUom { get; set; }
        public string TopLevelUserId { get; set; }
        public string MatAnalysisCode { get; set; }
        public string MatAnalysisCodeDesc { get; set; }
        public string OpAnalysisCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public bool? MakeDirectUi { get; set; }
        public int? NetStandingPlatesApp { get; set; }
        public int? NewPlatesChangesApp { get; set; }
        public decimal? LaborAdjApp { get; set; }
        public bool? MakeDirectApp { get; set; }
        public int? PlateIdSttc { get; set; }
        public int? PlateDescriptionOvrd { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? NetPlatesOvrd { get; set; }
        public int? NetStandingPlatesUiOvrd { get; set; }
        public int? NewPlatesChangesUiOvrd { get; set; }
        public int? WearoutreplacementOvrd { get; set; }
        public int? TotalPlateReplacementsOvrd { get; set; }
        public int? TotalNewplatesNeededOvrd { get; set; }
        public int? TotalNewPlateBurnsOvrd { get; set; }
        public int? LaborAdjUiOvrd { get; set; }
        public int? SetupHrOvrd { get; set; }
        public int? BurnHrOvrd { get; set; }
        public int? WidthOvrd { get; set; }
        public int? LengthOvrd { get; set; }
        public int? UomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? MatPartNumOvrd { get; set; }
        public int? MatPartIduiOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? MatMfgCommentOvrd { get; set; }
        public int? MatPurchCommentOvrd { get; set; }
        public int? PurchaseDirectOvrd { get; set; }
        public int? OpCommentOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? SubcPrListPriorityOvrd { get; set; }
        public int? SubcMatPartNumOvrd { get; set; }
        public int? SubcMatPartDescOvrd { get; set; }
        public int? SubcVendorNumOvrd { get; set; }
        public int? SubcVendorContactOvrd { get; set; }
        public int? SubcUomcostPlistOvrd { get; set; }
        public int? SubcUomcostNoPlistOvrd { get; set; }
        public int? SubcDaysOutOvrd { get; set; }
        public int? CostPerUnitaboveOvrd { get; set; }
        public int? VgorderInStdTypeOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? MatAnalysisCodeDescOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeDescOvrd { get; set; }
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

        public virtual EsMpoptions Option { get; set; }
        public virtual EsPlate Plate { get; set; }
    }
}
