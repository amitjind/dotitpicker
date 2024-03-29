﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImapinvDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string LineType { get; set; }
        public decimal UnitCost { get; set; }
        public decimal DocUnitCost { get; set; }
        public string PartNum { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string Description { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string JobSeqType { get; set; }
        public int JobSeq { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public decimal VendorQty { get; set; }
        public string Pum { get; set; }
        public decimal OurQty { get; set; }
        public string Ium { get; set; }
        public string CostPerCode { get; set; }
        public string VenPartNum { get; set; }
        public decimal ExtCost { get; set; }
        public decimal DocExtCost { get; set; }
        public decimal TotalMiscChrg { get; set; }
        public decimal DocTotalMiscChrg { get; set; }
        public string LineComment { get; set; }
        public DateTime? MatchDate { get; set; }
        public int MatchFiscalYear { get; set; }
        public int MatchFiscalPeriod { get; set; }
        public string TaxExempt { get; set; }
        public string TaxCatId { get; set; }
        public decimal AdvancePayAmt { get; set; }
        public decimal DocAdvancePayAmt { get; set; }
        public string PurchCode { get; set; }
        public decimal LineDiscAmt { get; set; }
        public decimal DocLineDiscAmt { get; set; }
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbInvoiceNum { get; set; }
        public int GlbInvoiceLine { get; set; }
        public decimal AdvGainLoss { get; set; }
        public bool MultiCompany { get; set; }
        public string RevChargeMethod { get; set; }
        public bool OverrideReverseCharge { get; set; }
        public bool RevChargeApplied { get; set; }
        public decimal Rpt1AdvancePayAmt { get; set; }
        public decimal Rpt2AdvancePayAmt { get; set; }
        public decimal Rpt3AdvancePayAmt { get; set; }
        public decimal Rpt1ExtCost { get; set; }
        public decimal Rpt2ExtCost { get; set; }
        public decimal Rpt3ExtCost { get; set; }
        public decimal Rpt1LineDiscAmt { get; set; }
        public decimal Rpt2LineDiscAmt { get; set; }
        public decimal Rpt3LineDiscAmt { get; set; }
        public decimal Rpt1TotalMiscChrg { get; set; }
        public decimal Rpt2TotalMiscChrg { get; set; }
        public decimal Rpt3TotalMiscChrg { get; set; }
        public decimal Rpt1UnitCost { get; set; }
        public decimal Rpt2UnitCost { get; set; }
        public decimal Rpt3UnitCost { get; set; }
        public decimal DocAdvPayAppld { get; set; }
        public decimal Rpt1AdvGainLoss { get; set; }
        public decimal Rpt2AdvGainLoss { get; set; }
        public decimal Rpt3AdvGainLoss { get; set; }
        public string MatchFiscalYearSuffix { get; set; }
        public string MatchFiscalCalendarId { get; set; }
        public string TaxRegionCode { get; set; }
        public int ContainerId { get; set; }
        public int DropShipPackLine { get; set; }
        public string DropShipPackSlip { get; set; }
        public bool CorrectionDtl { get; set; }
        public bool TaxConnectCalc { get; set; }
        public string AssetNum { get; set; }
        public int AdditionNum { get; set; }
        public int InvoiceLineRef { get; set; }
        public string IncomeTaxCode { get; set; }
        public decimal DocAssetInvoiceBal { get; set; }
        public decimal AssetBalOurQty { get; set; }
        public string AssetQtyIum { get; set; }
        public int Dmrnum { get; set; }
        public int DmractionNum { get; set; }
        public bool CreatedFromExpense { get; set; }
        public decimal InUnitCost { get; set; }
        public decimal DocInUnitCost { get; set; }
        public decimal Rpt1InUnitCost { get; set; }
        public decimal Rpt2InUnitCost { get; set; }
        public decimal Rpt3InUnitCost { get; set; }
        public decimal InExtCost { get; set; }
        public decimal DocInExtCost { get; set; }
        public decimal Rpt1InExtCost { get; set; }
        public decimal Rpt2InExtCost { get; set; }
        public decimal Rpt3InExtCost { get; set; }
        public decimal InTotalMiscChrg { get; set; }
        public decimal DocInTotalMiscChrg { get; set; }
        public decimal Rpt1InTotalMiscChrg { get; set; }
        public decimal Rpt2InTotalMiscChrg { get; set; }
        public decimal Rpt3InTotalMiscChrg { get; set; }
        public decimal InAdvancePayAmt { get; set; }
        public decimal DocInAdvancePayAmt { get; set; }
        public decimal Rpt1InAdvancePayAmt { get; set; }
        public decimal Rpt2InAdvancePayAmt { get; set; }
        public decimal Rpt3InAdvancePayAmt { get; set; }
        public decimal InLineDiscAmt { get; set; }
        public decimal DocInLineDiscAmt { get; set; }
        public decimal Rpt1InLineDiscAmt { get; set; }
        public decimal Rpt2InLineDiscAmt { get; set; }
        public decimal Rpt3InLineDiscAmt { get; set; }
        public bool NoTaxRecal { get; set; }
        public int DevInt1 { get; set; }
        public int DevInt2 { get; set; }
        public decimal DevDec1 { get; set; }
        public decimal DevDec2 { get; set; }
        public decimal DevDec3 { get; set; }
        public decimal DevDec4 { get; set; }
        public bool DevLog1 { get; set; }
        public bool DevLog2 { get; set; }
        public string DevChar1 { get; set; }
        public string DevChar2 { get; set; }
        public DateTime? DevDate1 { get; set; }
        public DateTime? DevDate2 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal ScrWithholdAmt { get; set; }
        public decimal DocScrWithholdAmt { get; set; }
        public decimal Rpt1ScrWithholdAmt { get; set; }
        public decimal Rpt2ScrWithholdAmt { get; set; }
        public decimal Rpt3ScrWithholdAmt { get; set; }
        public string InvoiceRef { get; set; }
        public int AptranNo { get; set; }
        public decimal DocAdvPayAppliedAmt { get; set; }
        public string Code1099Id { get; set; }
        public string Gen1099Code { get; set; }
        public string FormTypeId { get; set; }
        public bool DeisServices { get; set; }
        public bool DeisSecurityFinancialDerivative { get; set; }
        public string DeinternationalSecuritiesId { get; set; }
        public bool DeisInvestment { get; set; }
        public string DepayStatCode { get; set; }
        public bool DeferredExp { get; set; }
        public string Deacode { get; set; }
        public decimal Deaamt { get; set; }
        public DateTime? DeastartDate { get; set; }
        public DateTime? DeaendDate { get; set; }
        public string Dedenomination { get; set; }
        public string ExternalPonum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string MyimportNum { get; set; }
        public bool FinalInvoice { get; set; }
        public string CommodityCode { get; set; }
        public decimal TotalTax { get; set; }
        public decimal DocTotalTax { get; set; }
        public decimal Rpt1TotalTax { get; set; }
        public decimal Rpt2TotalTax { get; set; }
        public decimal Rpt3TotalTax { get; set; }
        public decimal TotalSatax { get; set; }
        public decimal DocTotalSatax { get; set; }
        public decimal Rpt1TotalSatax { get; set; }
        public decimal Rpt2TotalSatax { get; set; }
        public decimal Rpt3TotalSatax { get; set; }
        public decimal TotalDedTax { get; set; }
        public decimal DocTotalDedTax { get; set; }
        public decimal Rpt1TotalDedTax { get; set; }
        public decimal Rpt2TotalDedTax { get; set; }
        public decimal Rpt3TotalDedTax { get; set; }
        public int PbinvNum { get; set; }
    }
}
