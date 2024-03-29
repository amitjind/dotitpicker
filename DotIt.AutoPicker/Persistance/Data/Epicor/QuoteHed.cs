﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QuoteHed
    {
        public QuoteHed()
        {
            QuoteHedTax = new HashSet<QuoteHedTax>();
        }

        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int CustNum { get; set; }
        public DateTime? EntryDate { get; set; }
        public int PrcConNum { get; set; }
        public string QuoteComment { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Quoted { get; set; }
        public DateTime? DateQuoted { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string Reference { get; set; }
        public bool CheckOff1 { get; set; }
        public bool CheckOff2 { get; set; }
        public bool CheckOff3 { get; set; }
        public bool CheckOff4 { get; set; }
        public bool CheckOff5 { get; set; }
        public bool Expired { get; set; }
        public bool FlwAlrtSnt { get; set; }
        public bool DueAlrtSnt { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string LeadRating { get; set; }
        public string TerritoryId { get; set; }
        public string TaskSetId { get; set; }
        public string CurrentStage { get; set; }
        public int ParentQuoteNum { get; set; }
        public string ActiveTaskId { get; set; }
        public string LastTaskId { get; set; }
        public DateTime? ExpectedClose { get; set; }
        public string ReasonType { get; set; }
        public string ReasonCode { get; set; }
        public int ConfidencePct { get; set; }
        public decimal DiscountPercent { get; set; }
        public string ShipToNum { get; set; }
        public int ShpConNum { get; set; }
        public bool QuoteClosed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ShipViaCode { get; set; }
        public string MktgCampaignId { get; set; }
        public int MktgEvntSeq { get; set; }
        public string CallTypeCode { get; set; }
        public string Ponum { get; set; }
        public string TermsCode { get; set; }
        public bool Ordered { get; set; }
        public bool ApplyOrderBasedDisc { get; set; }
        public bool AutoOrderBasedDisc { get; set; }
        public int HdcaseNum { get; set; }
        public int BtcustNum { get; set; }
        public bool LockRate { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool ReadyToCalc { get; set; }
        public string ExportRequested { get; set; }
        public decimal Rounding { get; set; }
        public decimal DocRounding { get; set; }
        public decimal Rpt1Rounding { get; set; }
        public decimal Rpt2Rounding { get; set; }
        public decimal Rpt3Rounding { get; set; }
        public string RateGrpCode { get; set; }
        public decimal QuoteAmt { get; set; }
        public decimal DocQuoteAmt { get; set; }
        public decimal Rpt1QuoteAmt { get; set; }
        public decimal Rpt2QuoteAmt { get; set; }
        public decimal Rpt3QuoteAmt { get; set; }
        public bool UseOts { get; set; }
        public string Otsname { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string OtsresaleId { get; set; }
        public string OtstaxRegionCode { get; set; }
        public string Otscontact { get; set; }
        public string OtsfaxNum { get; set; }
        public string OtsphoneNum { get; set; }
        public int OtscountryNum { get; set; }
        public int ShipToCustNum { get; set; }
        public bool InPrice { get; set; }
        public int WorstCsPct { get; set; }
        public int BestCsPct { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public bool Ediready { get; set; }
        public bool Ediquote { get; set; }
        public bool Ediack { get; set; }
        public int OutboundQuoteDocCtr { get; set; }
        public DateTime? DemandProcessDate { get; set; }
        public int DemandProcessTime { get; set; }
        public string LastTctrlNum { get; set; }
        public string LastBatchNum { get; set; }
        public bool AutoPrintReady { get; set; }
        public decimal DocTotalSatax { get; set; }
        public decimal DocTotalTax { get; set; }
        public decimal DocTotalWhtax { get; set; }
        public decimal Rpt1TotalSatax { get; set; }
        public decimal Rpt1TotalTax { get; set; }
        public decimal Rpt1TotalWhtax { get; set; }
        public decimal Rpt2TotalSatax { get; set; }
        public decimal Rpt2TotalTax { get; set; }
        public decimal Rpt2TotalWhtax { get; set; }
        public decimal Rpt3TotalSatax { get; set; }
        public decimal DeclaredAmt { get; set; }
        public decimal Rpt3TotalTax { get; set; }
        public bool DeclaredIns { get; set; }
        public decimal Rpt3TotalWhtax { get; set; }
        public int DeliveryConf { get; set; }
        public DateTime? TaxPoint { get; set; }
        public string DeliveryType { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public bool DocOnly { get; set; }
        public string TaxRegionCode { get; set; }
        public bool DropShip { get; set; }
        public decimal TotalSatax { get; set; }
        public string ExtCompany { get; set; }
        public decimal TotalTax { get; set; }
        public string GroundType { get; set; }
        public decimal TotalWhtax { get; set; }
        public bool Hazmat { get; set; }
        public int Icponum { get; set; }
        public bool Linked { get; set; }
        public bool LockQty { get; set; }
        public DateTime? NeedByDate { get; set; }
        public string NotifyEmail { get; set; }
        public bool NotifyFlag { get; set; }
        public bool OtscustSaved { get; set; }
        public string OtssaveAs { get; set; }
        public string OtssaveCustId { get; set; }
        public bool OverrideCarrier { get; set; }
        public bool OverrideService { get; set; }
        public string RefNotes { get; set; }
        public DateTime? RequestDate { get; set; }
        public bool ResDelivery { get; set; }
        public bool SatPickup { get; set; }
        public bool ServAlert { get; set; }
        public string ServAuthNum { get; set; }
        public DateTime? ServDeliveryDate { get; set; }
        public bool ServHomeDel { get; set; }
        public string ServInstruct { get; set; }
        public string ServPhone { get; set; }
        public string ServRef1 { get; set; }
        public string ServRef2 { get; set; }
        public string ServRef3 { get; set; }
        public string ServRef4 { get; set; }
        public string ServRef5 { get; set; }
        public bool ServRelease { get; set; }
        public bool ServSignature { get; set; }
        public bool VoidQuote { get; set; }
        public bool ApplyChrg { get; set; }
        public decimal ChrgAmount { get; set; }
        public bool Cod { get; set; }
        public decimal TotalDiscPct { get; set; }
        public decimal TotalExpected { get; set; }
        public decimal TotalGrossValue { get; set; }
        public decimal TotalMiscAmt { get; set; }
        public decimal TotalPotential { get; set; }
        public decimal TotalWorstCs { get; set; }
        public decimal DocTotalBestCs { get; set; }
        public decimal DocTotalDiscount { get; set; }
        public decimal DocTotalDiscPct { get; set; }
        public decimal DocTotalExpected { get; set; }
        public decimal DocTotalGrossValue { get; set; }
        public decimal DocTotalMiscAmt { get; set; }
        public decimal DocTotalPotential { get; set; }
        public decimal DocTotalWorstCs { get; set; }
        public decimal Rpt1TotalBestCs { get; set; }
        public decimal Rpt1TotalDiscount { get; set; }
        public decimal Rpt1TotalDiscPct { get; set; }
        public decimal Rpt1TotalExpected { get; set; }
        public decimal Rpt1TotalGrossValue { get; set; }
        public decimal Rpt1TotalMiscAmt { get; set; }
        public decimal Rpt1TotalPotential { get; set; }
        public decimal Rpt1TotalWorstCs { get; set; }
        public decimal Rpt2TotalBestCs { get; set; }
        public decimal Rpt2TotalDiscount { get; set; }
        public decimal Rpt2TotalDiscPct { get; set; }
        public decimal Rpt2TotalExpected { get; set; }
        public decimal Rpt2TotalGrossValue { get; set; }
        public decimal Rpt2TotalMiscAmt { get; set; }
        public decimal Rpt2TotalPotential { get; set; }
        public decimal Rpt2TotalWorstCs { get; set; }
        public decimal Rpt3TotalBestCs { get; set; }
        public decimal Rpt3TotalDiscount { get; set; }
        public decimal Rpt3TotalDiscPct { get; set; }
        public decimal Rpt3TotalExpected { get; set; }
        public decimal Rpt3TotalGrossValue { get; set; }
        public decimal Rpt3TotalMiscAmt { get; set; }
        public decimal Rpt3TotalPotential { get; set; }
        public decimal Rpt3TotalWorstCs { get; set; }
        public decimal TotalBestCs { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal Codamount { get; set; }
        public bool Codcheck { get; set; }
        public bool Codfreight { get; set; }
        public string LoqprepressText { get; set; }
        public bool LoqnewPageOnQuoteLine { get; set; }
        public bool LoqbookPcfinishing { get; set; }
        public bool LoqbookPcpaper { get; set; }
        public bool LoqbookPcpress { get; set; }
        public bool LoqbookPcplates { get; set; }
        public bool Loqvariations { get; set; }
        public string Aeploqtype { get; set; }
        public string LoqprepressStyle { get; set; }
        public string QuoteCsr { get; set; }
        public string DueHour { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Eccconfirmed { get; set; }
        public string EccconfirmedBy { get; set; }
        public string EccmsgType { get; set; }
        public bool EccwebReady { get; set; }
        public string EccquoteNum { get; set; }
        public string EcccmmtRef { get; set; }
        public string Ecccomment { get; set; }
        public string Eccstatus { get; set; }
        public DateTime? EccexpirationDate { get; set; }
        public string EcccmmtRefSk { get; set; }
        public bool ExternalCrmquote { get; set; }
        public string ExternalCrmquoteId { get; set; }
        public string ExternalCrmorderId { get; set; }
        public string EccsalesRepId { get; set; }
        public decimal Tax { get; set; }
        public decimal DocTax { get; set; }
        public decimal Rpt1Tax { get; set; }
        public decimal Rpt2Tax { get; set; }
        public decimal Rpt3Tax { get; set; }
        public bool HdrTaxNoUpdt { get; set; }
        public DateTime? ExternalCrmlastSync { get; set; }
        public bool ExternalCrmsyncRequired { get; set; }
        public decimal TotalClaimsCredit { get; set; }
        public decimal DocTotalClaimsCredit { get; set; }
        public decimal Rpt1TotalClaimsCredit { get; set; }
        public decimal Rpt2TotalClaimsCredit { get; set; }
        public decimal Rpt3TotalClaimsCredit { get; set; }
        public decimal TotalClaimsTax { get; set; }
        public decimal DocTotalClaimsTax { get; set; }
        public decimal Rpt1TotalClaimsTax { get; set; }
        public decimal Rpt2TotalClaimsTax { get; set; }
        public decimal Rpt3TotalClaimsTax { get; set; }
        public decimal TotalClaimsSatax { get; set; }
        public decimal DocTotalClaimsSatax { get; set; }
        public decimal Rpt1TotalClaimsSatax { get; set; }
        public decimal Rpt2TotalClaimsSatax { get; set; }
        public decimal Rpt3TotalClaimsSatax { get; set; }
        public decimal TotalClaimsWhtax { get; set; }
        public decimal DocTotalClaimsWhtax { get; set; }
        public decimal Rpt1TotalClaimsWhtax { get; set; }
        public decimal Rpt2TotalClaimsWhtax { get; set; }
        public decimal Rpt3TotalClaimsWhtax { get; set; }

        public virtual ICollection<QuoteHedTax> QuoteHedTax { get; set; }
    }
}
