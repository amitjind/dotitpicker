﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImorderDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool VoidLine { get; set; }
        public bool OpenLine { get; set; }
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string LineType { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string Reference { get; set; }
        public string Ium { get; set; }
        public string RevisionNum { get; set; }
        public string Poline { get; set; }
        public bool Commissionable { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public decimal OrderQty { get; set; }
        public decimal Discount { get; set; }
        public decimal DocDiscount { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ProdCode { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public string PricePerCode { get; set; }
        public string OrderComment { get; set; }
        public string ShipComment { get; set; }
        public string InvoiceComment { get; set; }
        public string PickListComment { get; set; }
        public string TaxCatId { get; set; }
        public decimal AdvanceBillBal { get; set; }
        public decimal DocAdvanceBillBal { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public bool Tmbilling { get; set; }
        public string OrigWhyNoTax { get; set; }
        public DateTime? NeedByDate { get; set; }
        public int CustNum { get; set; }
        public bool Rework { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public string ProjectId { get; set; }
        public int ContractNum { get; set; }
        public string ContractCode { get; set; }
        public string BasePartNum { get; set; }
        public bool Warranty { get; set; }
        public string WarrantyCode { get; set; }
        public int MaterialDuration { get; set; }
        public int LaborDuration { get; set; }
        public int MiscDuration { get; set; }
        public string MaterialMod { get; set; }
        public string LaborMod { get; set; }
        public string WarrantyComment { get; set; }
        public bool Onsite { get; set; }
        public bool MatCovered { get; set; }
        public bool LabCovered { get; set; }
        public bool MiscCovered { get; set; }
        public string SalesUm { get; set; }
        public decimal SellingFactor { get; set; }
        public decimal SellingQuantity { get; set; }
        public string SalesCatId { get; set; }
        public bool ShipLineComplete { get; set; }
        public decimal CumeQty { get; set; }
        public DateTime? CumeDate { get; set; }
        public string MktgCampaignId { get; set; }
        public int MktgEvntSeq { get; set; }
        public bool LockQty { get; set; }
        public bool Linked { get; set; }
        public int Icponum { get; set; }
        public int Icpoline { get; set; }
        public string ExtCompany { get; set; }
        public DateTime? LastConfigDate { get; set; }
        public int LastConfigTime { get; set; }
        public string LastConfigUserId { get; set; }
        public decimal ConfigUnitPrice { get; set; }
        public decimal ConfigBaseUnitPrice { get; set; }
        public string PriceListCode { get; set; }
        public string BreakListCode { get; set; }
        public decimal PricingQty { get; set; }
        public bool LockPrice { get; set; }
        public decimal ListPrice { get; set; }
        public decimal DocListPrice { get; set; }
        public decimal OrdBasedPrice { get; set; }
        public decimal DocOrdBasedPrice { get; set; }
        public string PriceGroupCode { get; set; }
        public bool OverridePriceList { get; set; }
        public string BaseRevisionNum { get; set; }
        public decimal PricingValue { get; set; }
        public decimal DisplaySeq { get; set; }
        public int KitParentLine { get; set; }
        public bool KitAllowUpdate { get; set; }
        public bool KitShipComplete { get; set; }
        public bool KitBackFlush { get; set; }
        public bool KitPrintCompsPs { get; set; }
        public bool KitPrintCompsInv { get; set; }
        public string KitPricing { get; set; }
        public decimal KitQtyPer { get; set; }
        public string SellingFactorDirection { get; set; }
        public decimal RepRate1 { get; set; }
        public decimal RepRate2 { get; set; }
        public decimal RepRate3 { get; set; }
        public decimal RepRate4 { get; set; }
        public decimal RepRate5 { get; set; }
        public int RepSplit1 { get; set; }
        public int RepSplit2 { get; set; }
        public int RepSplit3 { get; set; }
        public int RepSplit4 { get; set; }
        public int RepSplit5 { get; set; }
        public int DemandContractLine { get; set; }
        public bool CreateNewJob { get; set; }
        public DateTime? DoNotShipBeforeDate { get; set; }
        public bool GetDtls { get; set; }
        public DateTime? DoNotShipAfterDate { get; set; }
        public bool SchedJob { get; set; }
        public bool RelJob { get; set; }
        public bool EnableCreateNewJob { get; set; }
        public bool EnableGetDtls { get; set; }
        public bool EnableSchedJob { get; set; }
        public bool EnableRelJob { get; set; }
        public string CounterSaleWarehouse { get; set; }
        public string CounterSaleBinNum { get; set; }
        public string CounterSaleLotNum { get; set; }
        public string CounterSaleDimCode { get; set; }
        public bool DemandDtlRejected { get; set; }
        public string KitFlag { get; set; }
        public bool KitsLoaded { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool ReverseCharge { get; set; }
        public int TotalReleases { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal Rpt1AdvanceBillBal { get; set; }
        public decimal Rpt2AdvanceBillBal { get; set; }
        public decimal Rpt3AdvanceBillBal { get; set; }
        public decimal Rpt1ListPrice { get; set; }
        public decimal Rpt2ListPrice { get; set; }
        public decimal Rpt3ListPrice { get; set; }
        public decimal Rpt1OrdBasedPrice { get; set; }
        public decimal Rpt2OrdBasedPrice { get; set; }
        public decimal Rpt3OrdBasedPrice { get; set; }
        public decimal ExtPriceDtl { get; set; }
        public decimal DocExtPriceDtl { get; set; }
        public decimal Rpt1ExtPriceDtl { get; set; }
        public decimal Rpt2ExtPriceDtl { get; set; }
        public decimal Rpt3ExtPriceDtl { get; set; }
        public string LineStatus { get; set; }
        public decimal InUnitPrice { get; set; }
        public decimal DocInUnitPrice { get; set; }
        public decimal InDiscount { get; set; }
        public decimal DocInDiscount { get; set; }
        public decimal InListPrice { get; set; }
        public decimal DocInListPrice { get; set; }
        public decimal InOrdBasedPrice { get; set; }
        public decimal DocInOrdBasedPrice { get; set; }
        public decimal Rpt1InUnitPrice { get; set; }
        public decimal Rpt2InUnitPrice { get; set; }
        public decimal Rpt3InUnitPrice { get; set; }
        public decimal Rpt1InDiscount { get; set; }
        public decimal Rpt2InDiscount { get; set; }
        public decimal Rpt3InDiscount { get; set; }
        public decimal Rpt1InListPrice { get; set; }
        public decimal Rpt2InListPrice { get; set; }
        public decimal Rpt3InListPrice { get; set; }
        public decimal Rpt1InOrdBasedPrice { get; set; }
        public decimal Rpt2InOrdBasedPrice { get; set; }
        public decimal Rpt3InOrdBasedPrice { get; set; }
        public decimal InExtPriceDtl { get; set; }
        public decimal DocInExtPriceDtl { get; set; }
        public decimal Rpt1InExtPriceDtl { get; set; }
        public decimal Rpt2InExtPriceDtl { get; set; }
        public decimal Rpt3InExtPriceDtl { get; set; }
        public decimal OldOurOpenQty { get; set; }
        public decimal OldSellingOpenQty { get; set; }
        public decimal OldOpenValue { get; set; }
        public string OldProdCode { get; set; }
        public decimal PrevSellQty { get; set; }
        public string PrevPartNum { get; set; }
        public string PrevXpartNum { get; set; }
        public int KitCompOrigSeq { get; set; }
        public string KitCompOrigPart { get; set; }
        public bool SmartStringProcessed { get; set; }
        public string SmartString { get; set; }
        public int RenewalNbr { get; set; }
        public string DiscBreakListCode { get; set; }
        public decimal DiscListPrice { get; set; }
        public bool LockDisc { get; set; }
        public bool OverrideDiscPriceList { get; set; }
        public int GroupSeq { get; set; }
        public string EccorderNum { get; set; }
        public int EccorderLine { get; set; }
        public bool DupOnJobCrt { get; set; }
        public decimal UndersPct { get; set; }
        public decimal Overs { get; set; }
        public decimal Unders { get; set; }
        public decimal OversUnitPrice { get; set; }
        public string PlanUserId { get; set; }
        public string PlanGuid { get; set; }
        public string MomsourceType { get; set; }
        public string MomsourceEst { get; set; }
        public string DefaultOversPricing { get; set; }
        public string Eccplant { get; set; }
        public string EccquoteNum { get; set; }
        public int EccquoteLine { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string MfgJobType { get; set; }
        public string ProFormaInvComment { get; set; }
        public bool CreateJob { get; set; }
        public string ContractId { get; set; }
        public bool LinkToContract { get; set; }
        public decimal DocInAdvanceBillBal { get; set; }
        public decimal InAdvanceBillBal { get; set; }
        public decimal Rpt1InAdvanceBillBal { get; set; }
        public decimal Rpt2InAdvanceBillBal { get; set; }
        public decimal Rpt3InAdvanceBillBal { get; set; }
        public bool PclinkRemoved { get; set; }
        public int ShipBoxNumberC { get; set; }
        public decimal BoxWeightC { get; set; }
        public decimal NetWeightC { get; set; }
        public string OriginalOrderLineC { get; set; }
        public string PartShipCommentC { get; set; }
        public string CommodityCode { get; set; }
        public decimal Msrp { get; set; }
        public decimal DocMsrp { get; set; }
        public decimal Rpt1Msrp { get; set; }
        public decimal Rpt2Msrp { get; set; }
        public decimal Rpt3Msrp { get; set; }
        public decimal EndCustomerPrice { get; set; }
        public decimal DocEndCustomerPrice { get; set; }
        public decimal Rpt1EndCustomerPrice { get; set; }
        public decimal Rpt2EndCustomerPrice { get; set; }
        public decimal Rpt3EndCustomerPrice { get; set; }
        public decimal PromotionalPrice { get; set; }
        public decimal DocPromotionalPrice { get; set; }
        public decimal Rpt1PromotionalPrice { get; set; }
        public decimal Rpt2PromotionalPrice { get; set; }
        public decimal Rpt3PromotionalPrice { get; set; }
        public string OrderLineStatusCode { get; set; }
    }
}