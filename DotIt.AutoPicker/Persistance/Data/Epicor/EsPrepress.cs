﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsPrepress
    {
        public EsPrepress()
        {
            EsPartprepress = new HashSet<EsPartprepress>();
            EsPlatelink = new HashSet<EsPlatelink>();
            EsPrepressdefaultsdtl = new HashSet<EsPrepressdefaultsdtl>();
            EsPrepresse = new HashSet<EsPrepresse>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string PrepressUserId { get; set; }
        public string StdType { get; set; }
        public string StdTypeUserId { get; set; }
        public string PrepressDesc { get; set; }
        public string CustomerDesc { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public string OperationId { get; set; }
        public string OperationDesc { get; set; }
        public bool? Subcontracting { get; set; }
        public bool? SubcIsMatInPartsTbl { get; set; }
        public int? SubcVendorNum { get; set; }
        public string SubcVendorId { get; set; }
        public string SubcPartNum { get; set; }
        public string SubcPartDesc { get; set; }
        public string SubcPartUom { get; set; }
        public bool? IsZeroSubcUomfactorToBase { get; set; }
        public int? SubcDaysOut { get; set; }
        public int? SubcCostSourceSelected { get; set; }
        public string SubcUomoptionsCombo { get; set; }
        public decimal? SubcCostPerEach { get; set; }
        public bool? SubcPrListPriority { get; set; }
        public string LaborMarkupLevels { get; set; }
        public string LaborMarkupPercents { get; set; }
        public string DeptId { get; set; }
        public bool? Inactive { get; set; }
        public string MaterialMarkupLevels { get; set; }
        public string MaterialMarkupPercents { get; set; }
        public bool? AllowQtyDifferences { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartDesc { get; set; }
        public string CustomerMatDesc { get; set; }
        public decimal? SetupHr { get; set; }
        public string MainCalcUom { get; set; }
        public string LaborUom { get; set; }
        public decimal? HrPerPiece { get; set; }
        public bool? IsAreaUom { get; set; }
        public string MatCostSource { get; set; }
        public decimal? CostPerEach { get; set; }
        public decimal? CostPer { get; set; }
        public decimal? Width { get; set; }
        public decimal? WidthTmp { get; set; }
        public decimal? Length { get; set; }
        public decimal? LengthTmp { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public int? Uomselected { get; set; }
        public int? CostSourceSelected { get; set; }
        public string CostSourceOptions { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string EstUom { get; set; }
        public bool? IsZeroEstOrinvUomfactorToBase { get; set; }
        public string Ium { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? ConversionFactor { get; set; }
        public string CostSourceTexts { get; set; }
        public string UomoptionsCombo { get; set; }
        public string CostSourceTextsCombo { get; set; }
        public bool? PrListPriority { get; set; }
        public bool? MatIncluded { get; set; }
        public string GroupId { get; set; }
        public string GroupUserId { get; set; }
        public string EstimationDisplayGroup { get; set; }
        public bool? GroupToViewingGroup { get; set; }
        public string GroupOrderInStdType { get; set; }
        public string StdTypeOrderInMfgPlan { get; set; }
        public string OrderInGroup { get; set; }
        public bool? LaborIncluded { get; set; }
        public string UirecIdentifier { get; set; }
        public bool? MatLaborNotIncluded { get; set; }
        public bool? IsSchedResExist { get; set; }
        public bool? AllowInCurPlant { get; set; }
        public bool? ShowInRfq { get; set; }
        public bool? TmpTrue { get; set; }
        public string MatAnalysisCode { get; set; }
        public bool? MatIsMissingAnalysCode { get; set; }
        public string OpAnalysisCode { get; set; }
        public bool? OpIsMissingAnalysCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? SubcVendorNumOvrd { get; set; }
        public int? SubcPartDescOvrd { get; set; }
        public int? SubcPartUomOvrd { get; set; }
        public int? SubcDaysOutOvrd { get; set; }
        public int? SubcCostPerEachOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? CustomerMatDescOvrd { get; set; }
        public int? LaborUomOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? EstUomOvrd { get; set; }
        public int? IumOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string CalculateUnitsPer { get; set; }
        public decimal UnitsPerPart { get; set; }
        public bool CalcUnitsPerPage { get; set; }
        public decimal UnitsPerPage { get; set; }
        public bool CalcUnitsPerColor { get; set; }
        public decimal UnitsPerColor { get; set; }
        public bool CalcUnitsPerShtLength { get; set; }
        public decimal UnitsPerSheetLength { get; set; }
        public bool CalcUnitsPerShtWidth { get; set; }
        public decimal UnitsPerSheetWidth { get; set; }
        public bool CalcUnitsPerFinPlength { get; set; }
        public decimal UnitsPerFinPlength { get; set; }
        public bool CalcUnitsPerFinPwidth { get; set; }
        public decimal UnitsPerFinPwidth { get; set; }
        public bool CalcUnitsPerFixedLength { get; set; }
        public decimal UnitsPerFixedLength { get; set; }
        public bool CalcUnitsPerFixedWidth { get; set; }
        public decimal UnitsPerFixedWidth { get; set; }
        public bool CalcUnitsPerLyt { get; set; }
        public decimal UnitsPerLyt { get; set; }
        public bool CalcUnitsPerLg { get; set; }
        public decimal UnitsPerLg { get; set; }
        public bool CalcUnitsPerPlate { get; set; }
        public decimal UnitsPerPlate { get; set; }
        public decimal MultiplyUnitsByFactor { get; set; }
        public decimal? MinMatQty { get; set; }
        public decimal? MinProdHrs { get; set; }
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
        public virtual ICollection<EsPartprepress> EsPartprepress { get; set; }
        public virtual ICollection<EsPlatelink> EsPlatelink { get; set; }
        public virtual ICollection<EsPrepressdefaultsdtl> EsPrepressdefaultsdtl { get; set; }
        public virtual ICollection<EsPrepresse> EsPrepresse { get; set; }
    }
}
