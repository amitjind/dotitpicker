﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Impoheader
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool OpenOrder { get; set; }
        public bool VoidOrder { get; set; }
        public int Ponum { get; set; }
        public string EntryPerson { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Fob { get; set; }
        public string ShipViaCode { get; set; }
        public string TermsCode { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShipCountry { get; set; }
        public string BuyerId { get; set; }
        public bool FreightPp { get; set; }
        public int PrcConNum { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string CommentText { get; set; }
        public bool OrderHeld { get; set; }
        public string ShipToConName { get; set; }
        public bool ReadyToPrint { get; set; }
        public string PrintAs { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public int ShipCountryNum { get; set; }
        public bool LogChanges { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool Approve { get; set; }
        public string ApprovalStatus { get; set; }
        public decimal ApprovedAmount { get; set; }
        public bool PostToWeb { get; set; }
        public DateTime? PostDate { get; set; }
        public string VendorRefNum { get; set; }
        public bool ConfirmReq { get; set; }
        public bool Confirmed { get; set; }
        public string ConfirmVia { get; set; }
        public int OrderNum { get; set; }
        public string LegalNumber { get; set; }
        public bool Linked { get; set; }
        public string ExtCompany { get; set; }
        public string XrefPonum { get; set; }
        public bool ConsolidatedPo { get; set; }
        public string GlbCompany { get; set; }
        public bool ContractOrder { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public bool PrintHeaderAddress { get; set; }
        public string RateGrpCode { get; set; }
        public string Potype { get; set; }
        public string Aplocid { get; set; }
        public string TranDocTypeId { get; set; }
        public bool AutoPrintReady { get; set; }
        public bool Icpolocked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PromiseDate { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public bool PotaxReadyToProcess { get; set; }
        public string TaxRegionCode { get; set; }
        public DateTime? TaxPoint { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public decimal TotalTax { get; set; }
        public decimal DocTotalTax { get; set; }
        public decimal Rpt1TotalTax { get; set; }
        public decimal Rpt2TotalTax { get; set; }
        public decimal Rpt3TotalTax { get; set; }
        public decimal TotalWhTax { get; set; }
        public decimal DocTotalWhTax { get; set; }
        public decimal Rpt1TotalWhTax { get; set; }
        public decimal Rpt2TotalWhTax { get; set; }
        public decimal Rpt3TotalWhTax { get; set; }
        public decimal TotalSatax { get; set; }
        public decimal DocTotalSatax { get; set; }
        public decimal Rpt1TotalSatax { get; set; }
        public decimal Rpt2TotalSatax { get; set; }
        public decimal Rpt3TotalSatax { get; set; }
        public bool InPrice { get; set; }
        public bool HdrTaxNoUpdt { get; set; }
        public string TaxRateGrpCode { get; set; }
        public decimal TotalDedTax { get; set; }
        public decimal DocTotalDedTax { get; set; }
        public decimal Rpt1TotalDedTax { get; set; }
        public decimal Rpt2TotalDedTax { get; set; }
        public decimal Rpt3TotalDedTax { get; set; }
        public decimal TotalCharges { get; set; }
        public decimal TotalMiscCharges { get; set; }
        public decimal TotalOrder { get; set; }
        public decimal DocTotalCharges { get; set; }
        public decimal DocTotalMisc { get; set; }
        public decimal DocTotalOrder { get; set; }
        public decimal Rpt1TotalCharges { get; set; }
        public decimal Rpt2TotalCharges { get; set; }
        public decimal Rpt3TotalCharges { get; set; }
        public decimal Rpt1TotalMiscCharges { get; set; }
        public decimal Rpt2TotalMiscCharges { get; set; }
        public decimal Rpt3TotalMiscCharges { get; set; }
        public decimal Rpt1TotalOrder { get; set; }
        public decimal Rpt2TotalOrder { get; set; }
        public decimal Rpt3TotalOrder { get; set; }
    }
}