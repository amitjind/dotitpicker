﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class InvcHead
    {
        public InvcHead()
        {
            InvcSched = new HashSet<InvcSched>();
            MxinvcRef = new HashSet<MxinvcRef>();
        }

        public string Company { get; set; }
        public bool OpenInvoice { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool CreditMemo { get; set; }
        public bool UnappliedCash { get; set; }
        public string CheckRef { get; set; }
        public string InvoiceSuffix { get; set; }
        public string GroupId { get; set; }
        public bool Posted { get; set; }
        public int InvoiceNum { get; set; }
        public string InvoiceType { get; set; }
        public bool DeferredRevenue { get; set; }
        public int OrderNum { get; set; }
        public int CustNum { get; set; }
        public string Ponum { get; set; }
        public string EntryPerson { get; set; }
        public string Fob { get; set; }
        public string TermsCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public bool Glposted { get; set; }
        public string InvoiceComment { get; set; }
        public decimal InvoiceAmt { get; set; }
        public decimal DocInvoiceAmt { get; set; }
        public decimal InvoiceBal { get; set; }
        public decimal DocInvoiceBal { get; set; }
        public decimal UnpostedBal { get; set; }
        public decimal DocUnpostedBal { get; set; }
        public decimal DepositCredit { get; set; }
        public decimal DocDepositCredit { get; set; }
        public string SalesRepList { get; set; }
        public int InvoiceRef { get; set; }
        public int RefCancelled { get; set; }
        public int RefCancelledBy { get; set; }
        public bool StartUp { get; set; }
        public string PayDates { get; set; }
        public string PayAmounts { get; set; }
        public string DocPayAmounts { get; set; }
        public DateTime? PayDiscDate { get; set; }
        public decimal PayDiscAmt { get; set; }
        public decimal DocPayDiscAmt { get; set; }
        public int BillConNum { get; set; }
        public bool InvoiceHeld { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public int JournalNum { get; set; }
        public string JournalCode { get; set; }
        public string LineType { get; set; }
        public int Rmanum { get; set; }
        public string Plant { get; set; }
        public string CardMemberName { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string CardId { get; set; }
        public string CardmemberReference { get; set; }
        public string LegalNumber { get; set; }
        public string ExternalId { get; set; }
        public string XrefInvoiceNum { get; set; }
        public decimal DepGainLoss { get; set; }
        public string Dncomments { get; set; }
        public string DncustNbr { get; set; }
        public bool DebitNote { get; set; }
        public int SoldToCustNum { get; set; }
        public bool Consolidated { get; set; }
        public bool BillToInvoiceAddress { get; set; }
        public bool SoldToInvoiceAddress { get; set; }
        public string ProcessCard { get; set; }
        public decimal RepComm1 { get; set; }
        public decimal RepComm2 { get; set; }
        public decimal RepComm3 { get; set; }
        public decimal RepComm4 { get; set; }
        public decimal RepComm5 { get; set; }
        public decimal RepRate1 { get; set; }
        public decimal RepRate2 { get; set; }
        public decimal RepRate3 { get; set; }
        public decimal RepRate4 { get; set; }
        public decimal RepRate5 { get; set; }
        public decimal RepSales1 { get; set; }
        public decimal RepSales2 { get; set; }
        public decimal RepSales3 { get; set; }
        public decimal RepSales4 { get; set; }
        public decimal RepSales5 { get; set; }
        public int RepSplit1 { get; set; }
        public int RepSplit2 { get; set; }
        public int RepSplit3 { get; set; }
        public int RepSplit4 { get; set; }
        public int RepSplit5 { get; set; }
        public string Cmtype { get; set; }
        public string CcstreetAddr { get; set; }
        public string Cczip { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool ReadyToCalc { get; set; }
        public bool AutoPrintReady { get; set; }
        public bool Ediready { get; set; }
        public bool RecalcBeforePost { get; set; }
        public decimal Rounding { get; set; }
        public decimal DocRounding { get; set; }
        public decimal Rpt1DepositCredit { get; set; }
        public decimal Rpt2DepositCredit { get; set; }
        public decimal Rpt3DepositCredit { get; set; }
        public decimal Rpt1InvoiceAmt { get; set; }
        public decimal Rpt2InvoiceAmt { get; set; }
        public decimal Rpt3InvoiceAmt { get; set; }
        public decimal Rpt1InvoiceBal { get; set; }
        public decimal Rpt2InvoiceBal { get; set; }
        public decimal Rpt3InvoiceBal { get; set; }
        public string Rpt1PayAmounts { get; set; }
        public string Rpt2PayAmounts { get; set; }
        public string Rpt3PayAmounts { get; set; }
        public decimal Rpt1PayDiscAmt { get; set; }
        public decimal Rpt2PayDiscAmt { get; set; }
        public decimal Rpt3PayDiscAmt { get; set; }
        public decimal Rpt1Rounding { get; set; }
        public decimal Rpt2Rounding { get; set; }
        public decimal Rpt3Rounding { get; set; }
        public decimal Rpt1UnpostedBal { get; set; }
        public decimal Rpt2UnpostedBal { get; set; }
        public decimal Rpt3UnpostedBal { get; set; }
        public string RateGrpCode { get; set; }
        public decimal DocDepApplied { get; set; }
        public decimal Rpt1DepGainLoss { get; set; }
        public decimal Rpt2DepGainLoss { get; set; }
        public decimal Rpt3DepGainLoss { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public DateTime? TaxPoint { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public string TaxRegionCode { get; set; }
        public DateTime? LastChrgCalcDate { get; set; }
        public string TranDocTypeId { get; set; }
        public decimal TotFinChrg { get; set; }
        public bool DocumentPrinted { get; set; }
        public string PayDiscDays { get; set; }
        public string PayDiscPer { get; set; }
        public bool BlockedFinChrg { get; set; }
        public string BlockedFinChrgReason { get; set; }
        public decimal WithholdAmt { get; set; }
        public decimal DocWithholdAmt { get; set; }
        public decimal Rpt1WithholdAmt { get; set; }
        public decimal Rpt2WithholdAmt { get; set; }
        public decimal Rpt3WithholdAmt { get; set; }
        public bool BlockedRemLetters { get; set; }
        public bool PayDiscPartPay { get; set; }
        public string BlockedRemLettersReason { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? CurrRateDate { get; set; }
        public string Pipayment { get; set; }
        public int Pmuid { get; set; }
        public bool UseAltBillTo { get; set; }
        public bool InPrice { get; set; }
        public bool CorrectionInv { get; set; }
        public string TaxRateGrpCode { get; set; }
        public bool LockTaxRate { get; set; }
        public string SebankRef { get; set; }
        public string GuitaxTypeCode { get; set; }
        public string GuiformatCode { get; set; }
        public string GuideductCode { get; set; }
        public decimal ReversalDocAmount { get; set; }
        public DateTime? OrigDueDate { get; set; }
        public int HeadNum { get; set; }
        public string Arlocid { get; set; }
        public string ContractRef { get; set; }
        public string OurBank { get; set; }
        public DateTime? ContractDate { get; set; }
        public string PbprojectId { get; set; }
        public decimal DepositAmt { get; set; }
        public string GuiexportBillNumber { get; set; }
        public decimal DocDepositAmt { get; set; }
        public DateTime? GuidateOfExport { get; set; }
        public decimal Rpt1DepositAmt { get; set; }
        public string GuiexportType { get; set; }
        public decimal Rpt2DepositAmt { get; set; }
        public string GuiexportMark { get; set; }
        public decimal Rpt3DepositAmt { get; set; }
        public string GuiexportBillType { get; set; }
        public decimal DepUnallocatedAmt { get; set; }
        public DateTime? SummarizationDate { get; set; }
        public decimal DocDepUnallocatedAmt { get; set; }
        public DateTime? BillingDate { get; set; }
        public decimal Rpt1DepUnallocatedAmt { get; set; }
        public string BillingNumber { get; set; }
        public decimal Rpt2DepUnallocatedAmt { get; set; }
        public bool ReadyToBill { get; set; }
        public decimal Rpt3DepUnallocatedAmt { get; set; }
        public bool OvrDefTaxDate { get; set; }
        public string XrefContractNum { get; set; }
        public DateTime? XrefContractDate { get; set; }
        public bool MainSite { get; set; }
        public string SiteCode { get; set; }
        public string BranchId { get; set; }
        public string CustAgentName { get; set; }
        public string CustAgentTaxRegNo { get; set; }
        public string ExportType { get; set; }
        public string ExportReportNo { get; set; }
        public string RealEstateNo { get; set; }
        public bool Excluded { get; set; }
        public bool Deferred { get; set; }
        public string CycleCode { get; set; }
        public int Duration { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal MaxValueAmt { get; set; }
        public decimal DocMaxValueAmt { get; set; }
        public decimal Rpt1MaxValueAmt { get; set; }
        public decimal Rpt2MaxValueAmt { get; set; }
        public decimal Rpt3MaxValueAmt { get; set; }
        public bool HoldInvoice { get; set; }
        public bool CopyLatestInvoice { get; set; }
        public bool OverrideEndDate { get; set; }
        public bool CycleInactive { get; set; }
        public bool RecurSource { get; set; }
        public int InstanceNum { get; set; }
        public decimal RecurBalance { get; set; }
        public decimal DocRecurBalance { get; set; }
        public decimal Rpt1RecurBalance { get; set; }
        public decimal Rpt2RecurBalance { get; set; }
        public decimal Rpt3RecurBalance { get; set; }
        public DateTime? LastDate { get; set; }
        public string RecurringState { get; set; }
        public bool IsRecurring { get; set; }
        public string InvoiceNumList { get; set; }
        public bool IsAddedToGti { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ChisrcodeLine { get; set; }
        public string Cmreason { get; set; }
        public bool ThisImmatAdjustment { get; set; }
        public string AgauthorizationCode { get; set; }
        public DateTime? AgauthorizationDate { get; set; }
        public bool AguseGoodDefaultMark { get; set; }
        public string AgdocumentLetter { get; set; }
        public string AginvoicingPoint { get; set; }
        public string AglegalNumber { get; set; }
        public string AgprintingControlType { get; set; }
        public DateTime? RevisionDate { get; set; }
        public int RevisionNum { get; set; }
        public int TwdeclareYear { get; set; }
        public int TwdeclarePeriod { get; set; }
        public string TwgenerationType { get; set; }
        public string Twguigroup { get; set; }
        public string TwperiodPrefix { get; set; }
        public bool InvInCollections { get; set; }
        public bool CollectionsCust { get; set; }
        public int CounterArform { get; set; }
        public bool PostedRecog { get; set; }
        public DateTime? CnconfirmDate { get; set; }
        public string Mxsatseal { get; set; }
        public string Mxserie { get; set; }
        public string MxtaxRcptType { get; set; }
        public string MxfiscalFolio { get; set; }
        public int MxtotalPayments { get; set; }
        public string Mxfolio { get; set; }
        public string MxcertifiedTimestamp { get; set; }
        public string MxsatcertificateSn { get; set; }
        public string MxdigitalSeal { get; set; }
        public string MxpostedTimeStamp { get; set; }
        public string Mxcertificate { get; set; }
        public int MxapprovalYear { get; set; }
        public string Mxcbb { get; set; }
        public int MxapprovalNum { get; set; }
        public string MxoriginalStringTfd { get; set; }
        public int MxpaymentNum { get; set; }
        public string MxpaidAs { get; set; }
        public string MxcertificateSn { get; set; }
        public decimal MxoriginalAmount { get; set; }
        public string MxaccountNumber { get; set; }
        public DateTime? MxoriginalDate { get; set; }
        public string MxoriginalSeries { get; set; }
        public string MxoriginalFolio { get; set; }
        public string MxtaxRegime { get; set; }
        public string MxoriginalString { get; set; }
        public string MxpaymentName { get; set; }
        public bool Einvoice { get; set; }
        public int EinvStatus { get; set; }
        public string EinvTimestamp { get; set; }
        public string EinvUpdatedBy { get; set; }
        public string EinvException { get; set; }
        public bool WithTaxConfirm { get; set; }
        public bool UseAltBillToId { get; set; }
        public DateTime? MxcancelledDate { get; set; }
        public bool Overpaid { get; set; }
        public decimal OrdExchangeRate { get; set; }
        public int PeappayNum { get; set; }
        public string PebankNumber { get; set; }
        public decimal Pecharges { get; set; }
        public decimal Pecommissions { get; set; }
        public decimal PedetTaxAmt { get; set; }
        public string PedetTaxCurrencyCode { get; set; }
        public decimal PedischargeAmt { get; set; }
        public DateTime? PedischargeDate { get; set; }
        public decimal Peinterest { get; set; }
        public decimal PenoPayPenalty { get; set; }
        public decimal PesunatdepAmt { get; set; }
        public DateTime? PesunatdepDate { get; set; }
        public string PesunatdepNum { get; set; }
        public bool Peboeposted { get; set; }
        public decimal DocPeinterest { get; set; }
        public decimal DocPecommissions { get; set; }
        public decimal DocPecharges { get; set; }
        public decimal DocPenoPayPenalty { get; set; }
        public decimal DocPedischargeAmt { get; set; }
        public decimal DocPedetTaxAmt { get; set; }
        public decimal Rpt1Peinterest { get; set; }
        public decimal Rpt1Pecommissions { get; set; }
        public decimal Rpt1Pecharges { get; set; }
        public decimal Rpt1PenoPayPenalty { get; set; }
        public decimal Rpt1PedischargeAmt { get; set; }
        public decimal Rpt2Peinterest { get; set; }
        public decimal Rpt2Pecommissions { get; set; }
        public decimal Rpt2Pecharges { get; set; }
        public decimal Rpt2PenoPayPenalty { get; set; }
        public decimal Rpt2PedischargeAmt { get; set; }
        public decimal Rpt3Peinterest { get; set; }
        public decimal Rpt3Pecommissions { get; set; }
        public decimal Rpt3Pecharges { get; set; }
        public decimal Rpt3PenoPayPenalty { get; set; }
        public decimal Rpt3PedischargeAmt { get; set; }
        public string OurSupplierCode { get; set; }
        public string PeguaranteeName { get; set; }
        public string PeguaranteeAddress1 { get; set; }
        public string PeguaranteeAddress2 { get; set; }
        public string PeguaranteeAddress3 { get; set; }
        public string PeguaranteeCity { get; set; }
        public string PeguaranteeState { get; set; }
        public string PeguaranteeZip { get; set; }
        public string PeguaranteeCountry { get; set; }
        public string PeguaranteeTaxId { get; set; }
        public string PeguaranteePhoneNum { get; set; }
        public string Peboestatus { get; set; }
        public bool PeboeisMultiGen { get; set; }
        public string PerefDocId { get; set; }
        public string PereasonCode { get; set; }
        public string PereasonDesc { get; set; }
        public string TwguiregNumSeller { get; set; }
        public string TwguiregNumBuyer { get; set; }
        public string TwguiexportDocumentName { get; set; }
        public string TwguiexportRemarks { get; set; }
        public string TwguiexportVerification { get; set; }
        public string PedebitNoteReasonCode { get; set; }
        public bool PedebitNote { get; set; }
        public bool MxpartPmt { get; set; }
        public int CntaxInvoiceType { get; set; }
        public string MxexportOperationType { get; set; }
        public string MxexportCustDocCode { get; set; }
        public string MxexportCertOriginNum { get; set; }
        public string MxexportConfNum { get; set; }
        public bool MxexportCertOrigin { get; set; }
        public string Mxincoterm { get; set; }
        public int AgdocConcept { get; set; }
        public string EinvRefNum { get; set; }
        public string ExportDocRefNum { get; set; }
        public DateTime? ExportDocDate { get; set; }
        public string IntaxTransactionId { get; set; }
        public bool MxmovingReasonFlag { get; set; }
        public string MxmovingReason { get; set; }
        public string MxnumRegIdTrib { get; set; }
        public int MxresidenCountryNum { get; set; }
        public string MxinvoiceRelationType { get; set; }
        public string MxpurchaseType { get; set; }
        public string MxconfirmationCode { get; set; }
        public string MxexternalCode { get; set; }
        public bool ServiceInvoice { get; set; }
        public bool MxdomesticTransfer { get; set; }
        public string MxcancellationMode { get; set; }
        public string InshippingPortCode { get; set; }
        public string InexportProcedure { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string DigitalSignature { get; set; }
        public DateTime? SignedOn { get; set; }
        public string SignedBy { get; set; }
        public DateTime? FirstPrintDate { get; set; }
        public int DocCopyNum { get; set; }
        public decimal DepositBalance { get; set; }
        public decimal DocDepositBalance { get; set; }
        public decimal Rpt1DepositBalance { get; set; }
        public decimal Rpt2DepositBalance { get; set; }
        public decimal Rpt3DepositBalance { get; set; }
        public int QuoteNum { get; set; }
        public int HdcaseNum { get; set; }
        public bool CreditOverride { get; set; }
        public DateTime? CreditOverrideDate { get; set; }
        public string CreditOverrideUserId { get; set; }
        public bool CreditHold { get; set; }
        public int Pexmltype { get; set; }
        public string CocreditMemoReasonCode { get; set; }
        public string CodebitMemoReasonCode { get; set; }
        public string CoreasonDesc { get; set; }
        public bool CodebitNote { get; set; }

        public virtual InvcHeadUd InvcHeadUd { get; set; }
        public virtual ICollection<InvcSched> InvcSched { get; set; }
        public virtual ICollection<MxinvcRef> MxinvcRef { get; set; }
    }
}