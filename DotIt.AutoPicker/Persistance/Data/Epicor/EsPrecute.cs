﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsPrecute
    {
        public EsPrecute()
        {
            EsInlinee = new HashSet<EsInlinee>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string CutterIdapp { get; set; }
        public string CutterId { get; set; }
        public string CuttingUserId { get; set; }
        public string CutterDescription { get; set; }
        public string CustomerDesc { get; set; }
        public string Plant { get; set; }
        public string EstimateId { get; set; }
        public string StdType { get; set; }
        public string PartId { get; set; }
        public string TmpPrePressCutToGrain { get; set; }
        public decimal? LiftHeight { get; set; }
        public decimal? LiftWeight { get; set; }
        public string CutFromPreCutGrain { get; set; }
        public decimal? CutFromWidthTotal { get; set; }
        public decimal? CutFromLengthTotal { get; set; }
        public decimal? CutToWidth { get; set; }
        public decimal? CutToLength { get; set; }
        public decimal? PressMaxWidth { get; set; }
        public decimal? PressMaxLength { get; set; }
        public bool? RotateCutToToFitOnPress { get; set; }
        public string CutToGrainOnPress { get; set; }
        public int? TmpNumOfOutCutFrom { get; set; }
        public int? TmpNumOfOutRotateCutFrom { get; set; }
        public bool? TempRotateCutFrom { get; set; }
        public string TempCutFromGrain { get; set; }
        public int? NumberOut { get; set; }
        public int? NumCutPrepressTmp { get; set; }
        public int? NumCutPostNotSheet { get; set; }
        public int? NumCutPostIsSheet { get; set; }
        public int? NumOfCuts { get; set; }
        public decimal? LaborAdjPct { get; set; }
        public decimal? SpoilAdjPct { get; set; }
        public int? SetupSheet { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgorderInStdType { get; set; }
        public string VgorderInPlan { get; set; }
        public string OrderWithinIdentical { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public decimal? ValueIfLastMain { get; set; }
        public decimal? QtyOutMain { get; set; }
        public decimal? QtyInMain { get; set; }
        public decimal? SpoilShts { get; set; }
        public decimal? QtyInMainStockShts { get; set; }
        public decimal? LiftsPerHr { get; set; }
        public decimal? InlineSetupHr { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? ProdHr { get; set; }
        public decimal? TotalHr { get; set; }
        public string SequenceNumber { get; set; }
        public string Source { get; set; }
        public bool? DutchCut { get; set; }
        public decimal? PctOfQty { get; set; }
        public decimal? QtyToCut { get; set; }
        public decimal? ProdShtsIncSpoil { get; set; }
        public decimal? TotalLifts { get; set; }
        public decimal? CutToNumOfOutWidth { get; set; }
        public decimal? CutToNumOfOutLength { get; set; }
        public decimal? WidthNumCutPrepress { get; set; }
        public decimal? LengthNumCutPrepress { get; set; }
        public decimal? LaborMarkup { get; set; }
        public string ShowInRoutingOrMaterial { get; set; }
        public string ProdOperationId { get; set; }
        public string ProdOperationDesc { get; set; }
        public string OpComment { get; set; }
        public string OperationBlname { get; set; }
        public string RgrpBlnameTmp { get; set; }
        public string OpDtlBlname { get; set; }
        public decimal? TempStockWeight { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public string StockEmainId { get; set; }
        public decimal? WastedQty { get; set; }
        public string OperCountUom { get; set; }
        public string TopLevelUserId { get; set; }
        public string OpAnalysisCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public int? CutterIdSttc { get; set; }
        public int? CutterDescriptionOvrd { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? LiftHeightOvrd { get; set; }
        public int? LiftWeightOvrd { get; set; }
        public int? CutFromPreCutGrainOvrd { get; set; }
        public int? CutToWidthOvrd { get; set; }
        public int? CutToLengthOvrd { get; set; }
        public int? NumberOutOvrd { get; set; }
        public int? NumOfCutsOvrd { get; set; }
        public int? LaborAdjPctOvrd { get; set; }
        public int? SpoilAdjPctOvrd { get; set; }
        public int? SetupSheetOvrd { get; set; }
        public int? VgorderInStdTypeOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
        public int? SpoilShtsOvrd { get; set; }
        public int? LiftsPerHrOvrd { get; set; }
        public int? InlineSetupHrOvrd { get; set; }
        public int? SetupHrOvrd { get; set; }
        public int? ProdHrOvrd { get; set; }
        public int? ProdShtsIncSpoilOvrd { get; set; }
        public int? OpCommentOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeDescOvrd { get; set; }
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
        public decimal? SetupAdjPct { get; set; }
        public int? SetupAdjPctOvrd { get; set; }

        public virtual EsCutting Cutter { get; set; }
        public virtual EsMpoptions Option { get; set; }
        public virtual EsStockemain StockEmain { get; set; }
        public virtual ICollection<EsInlinee> EsInlinee { get; set; }
    }
}
