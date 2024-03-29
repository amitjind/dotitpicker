﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsImpmain
    {
        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string PressId { get; set; }
        public string PressUserId { get; set; }
        public string JogSide { get; set; }
        public decimal? Milling { get; set; }
        public decimal? HeadTrim { get; set; }
        public decimal? FootTrim { get; set; }
        public decimal? FaceTrim { get; set; }
        public decimal? BackTrim { get; set; }
        public decimal? Spine { get; set; }
        public decimal? FrontLip { get; set; }
        public decimal? BackLip { get; set; }
        public decimal? HorizontalCreep { get; set; }
        public decimal? VerticalCreep { get; set; }
        public string PressSheet { get; set; }
        public decimal? SelecetedSheetUtilization { get; set; }
        public string OptimumShtsize { get; set; }
        public string ActualImpositionSize { get; set; }
        public decimal? ActualOptimalWidth { get; set; }
        public decimal? ActualOptimalLength { get; set; }
        public string ActualOptimalGrain { get; set; }
        public string StockRotatedOnPressUi { get; set; }
        public decimal? BleedSize { get; set; }
        public int? WorkingPieceType { get; set; }
        public string WorkingPieceSize { get; set; }
        public string PageGrainDirection { get; set; }
        public string PressSheetGrain { get; set; }
        public decimal? GripperGapAllowance { get; set; }
        public decimal? ColorBarSize { get; set; }
        public decimal? SideMargin { get; set; }
        public decimal? HeadFootMargin { get; set; }
        public string PageSize { get; set; }
        public bool? PbinPowerOf2 { get; set; }
        public int? PbuserDefined { get; set; }
        public int? MaxPgPerSection { get; set; }
        public string PreferredWorkStyle { get; set; }
        public string ImpoConcatLg { get; set; }
        public string VgorderInPlan { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string OrderInPlan { get; set; }
        public int? JogSideOvrd { get; set; }
        public int? MillingOvrd { get; set; }
        public int? HeadTrimOvrd { get; set; }
        public int? FootTrimOvrd { get; set; }
        public int? FaceTrimOvrd { get; set; }
        public int? BackTrimOvrd { get; set; }
        public int? SpineOvrd { get; set; }
        public int? FrontLipOvrd { get; set; }
        public int? BackLipOvrd { get; set; }
        public int? HorizontalCreepOvrd { get; set; }
        public int? VerticalCreepOvrd { get; set; }
        public int? GripperGapAllowanceOvrd { get; set; }
        public int? ColorBarSizeOvrd { get; set; }
        public int? SideMarginOvrd { get; set; }
        public int? HeadFootMarginOvrd { get; set; }
        public int? PbinPowerOf2Ovrd { get; set; }
        public int? PbuserDefinedOvrd { get; set; }
        public int? MaxPgPerSectionOvrd { get; set; }
        public int? PreferredWorkStyleOvrd { get; set; }
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
        public decimal? HeadTrimActual { get; set; }
        public decimal? FootTrimActual { get; set; }
        public decimal? FaceTrimActual { get; set; }
        public decimal? BackTrimActual { get; set; }

        public virtual EsMpoptions Option { get; set; }
    }
}
