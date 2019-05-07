﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartOpr
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int OprSeq { get; set; }
        public string OpCode { get; set; }
        public string OpStdId { get; set; }
        public decimal EstSetHours { get; set; }
        public decimal EstProdHours { get; set; }
        public decimal ProdStandard { get; set; }
        public string StdFormat { get; set; }
        public string StdBasis { get; set; }
        public int OpsPerPart { get; set; }
        public decimal QtyPer { get; set; }
        public int Machines { get; set; }
        public decimal SetUpCrewSize { get; set; }
        public decimal ProdCrewSize { get; set; }
        public decimal EstScrap { get; set; }
        public string EstScrapType { get; set; }
        public bool SubContract { get; set; }
        public string Ium { get; set; }
        public decimal EstUnitCost { get; set; }
        public decimal DaysOut { get; set; }
        public string SubPartNum { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string CommentText { get; set; }
        public string SchedRelation { get; set; }
        public decimal RunQty { get; set; }
        public decimal AddlSetupHours { get; set; }
        public decimal AddlSetUpQty { get; set; }
        public int ApsprepOp { get; set; }
        public int ApsnextOp { get; set; }
        public int ApsaltOp { get; set; }
        public string ApsspecificResource { get; set; }
        public decimal ApscycleTime { get; set; }
        public decimal ApsconstantTime { get; set; }
        public int ApssetupGroup { get; set; }
        public int ApsmakeFactor { get; set; }
        public decimal ApscontainerSize { get; set; }
        public string ApsschedulerName { get; set; }
        public decimal ApsmaxLength { get; set; }
        public decimal ApstransferTime { get; set; }
        public decimal Apseffectiveness { get; set; }
        public string ApsoperationClass { get; set; }
        public string ApsauxResource { get; set; }
        public string ApsaddResource { get; set; }
        public string LaborEntryMethod { get; set; }
        public decimal Faqty { get; set; }
        public bool Rfqneeded { get; set; }
        public int RfqvendQuotes { get; set; }
        public string SetupGroup { get; set; }
        public string AnalysisCode { get; set; }
        public int PrimarySetupOpDtl { get; set; }
        public int PrimaryProdOpDtl { get; set; }
        public int RtgGroup { get; set; }
        public string AltMethod { get; set; }
        public bool BaseMethodOverridden { get; set; }
        public string StageNumber { get; set; }
        public string OpDesc { get; set; }
        public string ParentAltMethod { get; set; }
        public int ParentOprSeq { get; set; }
        public decimal PbrkCost01 { get; set; }
        public decimal PbrkCost02 { get; set; }
        public decimal PbrkCost03 { get; set; }
        public decimal PbrkCost04 { get; set; }
        public decimal PbrkCost05 { get; set; }
        public decimal PbrkCost06 { get; set; }
        public decimal PbrkCost07 { get; set; }
        public decimal PbrkCost08 { get; set; }
        public decimal PbrkCost09 { get; set; }
        public decimal PbrkCost10 { get; set; }
        public decimal PbrkStdRate01 { get; set; }
        public decimal PbrkStdRate02 { get; set; }
        public decimal PbrkStdRate03 { get; set; }
        public decimal PbrkStdRate04 { get; set; }
        public decimal PbrkStdRate05 { get; set; }
        public decimal PbrkStdRate06 { get; set; }
        public decimal PbrkStdRate07 { get; set; }
        public decimal PbrkStdRate08 { get; set; }
        public decimal PbrkStdRate09 { get; set; }
        public decimal PbrkStdRate10 { get; set; }
        public decimal BrkQty01 { get; set; }
        public decimal BrkQty02 { get; set; }
        public decimal BrkQty03 { get; set; }
        public decimal BrkQty04 { get; set; }
        public decimal BrkQty05 { get; set; }
        public decimal BrkQty06 { get; set; }
        public decimal BrkQty07 { get; set; }
        public decimal BrkQty08 { get; set; }
        public decimal BrkQty09 { get; set; }
        public decimal BrkQty10 { get; set; }
        public bool SnrequiredOpr { get; set; }
        public bool SnrequiredSubConShip { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public string SendAheadType { get; set; }
        public decimal SendAheadOffset { get; set; }
        public string PrjRoleList { get; set; }
        public bool UseAllRoles { get; set; }
        public bool ExternalMes { get; set; }
        public decimal PctReg { get; set; }
        public decimal SetupMaterial { get; set; }
        public int MaterialColorRating { get; set; }
        public string MiscInfo1 { get; set; }
        public string MiscInfo2 { get; set; }
        public string SetupUrl { get; set; }
        public decimal ExpPctUp { get; set; }
        public decimal ExpCycTm { get; set; }
        public decimal ExpGood { get; set; }
        public decimal NonProdLimit { get; set; }
        public bool AutoSpcEnable { get; set; }
        public int AutoSpcPeriod { get; set; }
        public bool PartQualEnable { get; set; }
        public int AutoSpcSubgroup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int PulsesPerCycle { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
        public decimal QtyPerCycle { get; set; }
    }
}