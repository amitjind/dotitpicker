﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Project
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public bool ActiveProject { get; set; }
        public string CommentText { get; set; }
        public string PersonList { get; set; }
        public string UserMap { get; set; }
        public string UserMapData { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string PrimaryJob { get; set; }
        public int PrimaryMtl { get; set; }
        public string SalesCatId { get; set; }
        public string ProdCode { get; set; }
        public bool CloseAccrual { get; set; }
        public int PrimaryAsmSeq { get; set; }
        public DateTime? StartDate { get; set; }
        public int ConCustNum { get; set; }
        public DateTime? ConStartDate { get; set; }
        public DateTime? ConEndDate { get; set; }
        public DateTime? ConProjectedEnd { get; set; }
        public string ConReference { get; set; }
        public string ConProjMgr { get; set; }
        public decimal ConTotValue { get; set; }
        public decimal ConTotInv { get; set; }
        public string ConInvMeth { get; set; }
        public string MarkUpId { get; set; }
        public decimal PblbMarkUp { get; set; }
        public decimal PbmtlMarkUp { get; set; }
        public decimal PbsubMarkUp { get; set; }
        public decimal PbmiscMarkUp { get; set; }
        public decimal PbretentionPcnt { get; set; }
        public string PbretentionProc { get; set; }
        public decimal PbfeeProject { get; set; }
        public string PbfeeApply { get; set; }
        public string PbfeeType { get; set; }
        public string PbfeeApplyOn { get; set; }
        public string PbfeeInvoiceText { get; set; }
        public decimal PbfeeLbrCharge { get; set; }
        public string PbfeeLbrType { get; set; }
        public string PbfeeLbrApply { get; set; }
        public decimal PbfeeMtlCharge { get; set; }
        public string PbfeeMtlType { get; set; }
        public string PbfeeMtlApply { get; set; }
        public decimal PbfeeSubCharge { get; set; }
        public string PbfeeSubType { get; set; }
        public string PbfeeSubApply { get; set; }
        public decimal PbfeeMiscCharge { get; set; }
        public string PbfeeMiscType { get; set; }
        public string PbfeeMiscApply { get; set; }
        public string CurrencyCode { get; set; }
        public int ConBtcustNum { get; set; }
        public bool ConOverCeiling { get; set; }
        public string ConRevMethod { get; set; }
        public string ConListCode { get; set; }
        public string ConHrsInvc { get; set; }
        public string RateGrpCode { get; set; }
        public bool LockRate { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PbprjRtSrc { get; set; }
        public decimal DocConTotInv { get; set; }
        public bool CreatePrjJob { get; set; }
        public decimal Rpt1ConTotInv { get; set; }
        public int Revision { get; set; }
        public decimal Rpt2ConTotInv { get; set; }
        public decimal PpallowPcnt { get; set; }
        public decimal Rpt3ConTotInv { get; set; }
        public bool HoldPrdInv { get; set; }
        public decimal DocConTotValue { get; set; }
        public bool Ppactive { get; set; }
        public decimal Rpt1ConTotValue { get; set; }
        public decimal Rpt2ConTotValue { get; set; }
        public decimal TotLiqToDate { get; set; }
        public decimal Rpt3ConTotValue { get; set; }
        public decimal PpceilingTotal { get; set; }
        public decimal DocPbfeeLbrCharge { get; set; }
        public decimal Rpt1PbfeeLbrCharge { get; set; }
        public decimal Rpt2PbfeeLbrCharge { get; set; }
        public decimal Rpt3PbfeeLbrCharge { get; set; }
        public decimal DocPbfeeMiscCharge { get; set; }
        public decimal Rpt1PbfeeMiscCharge { get; set; }
        public decimal Rpt2PbfeeMiscCharge { get; set; }
        public decimal Rpt3PbfeeMiscCharge { get; set; }
        public decimal DocPbfeeMtlCharge { get; set; }
        public decimal Rpt1PbfeeMtlCharge { get; set; }
        public decimal Rpt2PbfeeMtlCharge { get; set; }
        public decimal Rpt3PbfeeMtlCharge { get; set; }
        public decimal DocPbfeeSubCharge { get; set; }
        public decimal Rpt1PbfeeSubCharge { get; set; }
        public decimal Rpt2PbfeeSubCharge { get; set; }
        public decimal Rpt3PbfeeSubCharge { get; set; }
        public bool PbindCeilingSup { get; set; }
        public bool PbindCeilingEmp { get; set; }
        public bool PbindCeilingProle { get; set; }
        public decimal PbdocInvoicedMtl { get; set; }
        public decimal PbdocInvoicedLbr { get; set; }
        public decimal PbdocInvoicedSub { get; set; }
        public decimal PbdocInvoicedMtlBur { get; set; }
        public decimal PbdocInvoicedMisc { get; set; }
        public decimal PbdocInvoicedBur { get; set; }
        public decimal PbdocInvoicedFees { get; set; }
        public int NextTmpInvcNum { get; set; }
        public decimal DocTotLiqToDate { get; set; }
        public decimal Rpt1TotLiqToDate { get; set; }
        public decimal Rpt2TotLiqToDate { get; set; }
        public decimal Rpt3TotLiqToDate { get; set; }
        public decimal DocPpceilingTotal { get; set; }
        public decimal Rpt1PpceilingTotal { get; set; }
        public decimal Rpt2PpceilingTotal { get; set; }
        public decimal Rpt3PpceilingTotal { get; set; }
        public int PborderNum { get; set; }
        public int PporderNum { get; set; }
        public int PborderLine { get; set; }
        public int PporderLine { get; set; }
        public decimal DocPbfeeProject { get; set; }
        public decimal Rpt1PbfeeProject { get; set; }
        public decimal Rpt2PbfeeProject { get; set; }
        public decimal Rpt3PbfeeProject { get; set; }
        public bool Pbclose { get; set; }
        public bool PbtrueUp { get; set; }
        public string TimeApprovalsMethod { get; set; }
        public string TimeWfgroupId { get; set; }
        public string ExpenseApprovalsMethod { get; set; }
        public string ExpenseWfgroupId { get; set; }
        public int PbnumInvoices { get; set; }
        public string PbtrueUpYearList { get; set; }
        public string Plant { get; set; }
        public int ConConNum { get; set; }
        public string MtlTaxCatId { get; set; }
        public string LbrTaxCatId { get; set; }
        public string FeeTaxCatId { get; set; }
        public string OdctaxCatId { get; set; }
        public string SubTaxCatId { get; set; }
        public string BdnTaxCatId { get; set; }
        public bool TaxOnNetOfRet { get; set; }
        public DateTime? LastAnalDate { get; set; }
        public bool RegenReqd { get; set; }
        public decimal PbceilingTotal { get; set; }
        public decimal DocPbceilingTotal { get; set; }
        public decimal Rpt1PbceilingTotal { get; set; }
        public decimal Rpt2PbceilingTotal { get; set; }
        public decimal Rpt3PbceilingTotal { get; set; }
        public decimal PbceilingFees { get; set; }
        public decimal DocPbceilingFees { get; set; }
        public decimal Rpt1PbceilingFees { get; set; }
        public decimal Rpt2PbceilingFees { get; set; }
        public decimal Rpt3PbceilingFees { get; set; }
        public bool ChkEmpPrjRole { get; set; }
        public decimal PpliquidPct { get; set; }
        public bool PpallOrderLines { get; set; }
        public bool PpallPrjJobs { get; set; }
        public bool AvoidPriceList { get; set; }
        public string PbsTaxCatId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
    }
}