﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Arsyst
    {
        public string Company { get; set; }
        public int StartInvoiceNum { get; set; }
        public bool SaveShipments { get; set; }
        public string CreditOrderAction { get; set; }
        public string CreditShipAction { get; set; }
        public string SjjournalCode { get; set; }
        public string AjjournalCode { get; set; }
        public bool UseShipDateForInvDate { get; set; }
        public string CreditContractAction { get; set; }
        public bool AutoNumChk { get; set; }
        public string DefaultFmtCode { get; set; }
        public string FmtCode { get; set; }
        public string RptFormDir { get; set; }
        public bool InvcReadyToCalcDflt { get; set; }
        public bool AllowReverseCharges { get; set; }
        public decimal RoundTolerance { get; set; }
        public bool TaxArcustomRules { get; set; }
        public string RlsClassCredit { get; set; }
        public string RlsClassReport { get; set; }
        public string RlsClassPayerSold { get; set; }
        public bool AcrossNatAcc { get; set; }
        public bool ProrateDiscToLine { get; set; }
        public bool LnreqForInvc { get; set; }
        public bool ChargeMethod { get; set; }
        public bool OncePerInvoice { get; set; }
        public bool CombWreminder { get; set; }
        public bool Arclearing { get; set; }
        public bool AllowSettlementInDiffCurr { get; set; }
        public string ArdefApplyDate { get; set; }
        public string ArdefShipDate { get; set; }
        public string ArdefTaxPdate { get; set; }
        public string ArdefCurrDate { get; set; }
        public string ArdefTaxRateD { get; set; }
        public string ArlinkApplyDate { get; set; }
        public string ArlinkShipDate { get; set; }
        public string ArlinkTaxPdate { get; set; }
        public string ArlinkCurrDate { get; set; }
        public string ArlinkTaxRateD { get; set; }
        public bool AramdApplyDate { get; set; }
        public bool AramdShipDate { get; set; }
        public bool AramdTaxPdate { get; set; }
        public bool AramdCurreDate { get; set; }
        public bool AramdTaxRateD { get; set; }
        public bool DatesSetUp { get; set; }
        public string ArdefTaxRcrD { get; set; }
        public bool AramdTaxRcrD { get; set; }
        public bool UseAltBillToAddr { get; set; }
        public bool CopyExchangeRate { get; set; }
        public string Glstage { get; set; }
        public bool EndorseAp { get; set; }
        public bool Glstatus { get; set; }
        public string UnapprovedStatus { get; set; }
        public string PortfolioStatus { get; set; }
        public string BankStatus { get; set; }
        public string SettledStatus { get; set; }
        public int NextPinum { get; set; }
        public int NumDigit { get; set; }
        public string PreferredBank { get; set; }
        public bool IsDiscountforCreditM { get; set; }
        public int MandateCounter { get; set; }
        public int SepaddmsgCounter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AllowConfirmationTax { get; set; }
        public bool UseAltBillToId { get; set; }
        public bool CopyExcRateCancelInv { get; set; }
        public bool CopyExcRateCm { get; set; }
        public int ExchangeDate { get; set; }
        public bool AllowOverpaidInv { get; set; }
        public bool AutoArbal { get; set; }
        public string CancelledStatus { get; set; }
        public bool AdjDocLevTax { get; set; }
        public bool RetainCreditOverride { get; set; }
        public bool LncashRecForUnappliedRec { get; set; }
        public bool AllowNegativeDiscount { get; set; }
        public bool AllowNegativeQuantity { get; set; }
        public bool UseControlledCm { get; set; }
        public bool UseCopyNumInArinv { get; set; }
        public string CreditLimitInvoiceAction { get; set; }
        public decimal MaxWriteOffAmt { get; set; }
        public bool AllowNegativeWriteOff { get; set; }
        public string DepTaxTreatment { get; set; }
        public bool DepAllowNegativeTax { get; set; }
        public string DepTaxCatId { get; set; }
        public bool DepInvcRequired { get; set; }
        public int DepDaysDelay { get; set; }
        public string DepTranDocTypeId { get; set; }
        public bool DepShowLinkedInvc { get; set; }
        public bool MandatoryArremittanceSlip { get; set; }
    }
}