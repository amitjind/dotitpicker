﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShipTo
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string ResaleId { get; set; }
        public string SalesRepCode { get; set; }
        public string TerritoryId { get; set; }
        public string ShipViaCode { get; set; }
        public int PrimScon { get; set; }
        public string FaxNum { get; set; }
        public string PhoneNum { get; set; }
        public string TaxExempt { get; set; }
        public string EdishipNum { get; set; }
        public int CountryNum { get; set; }
        public string LangNameId { get; set; }
        public string BorderCrossing { get; set; }
        public string FormatStr { get; set; }
        public string TaxRegionCode { get; set; }
        public string EmailAddress { get; set; }
        public string TerritorySelect { get; set; }
        public string PendingTerritoryId { get; set; }
        public bool CreatedByEdi { get; set; }
        public string ExternalId { get; set; }
        public string TaxAuthorityCode { get; set; }
        public bool GlobalLock { get; set; }
        public string Edicode { get; set; }
        public int DemandDeliveryDays { get; set; }
        public string DemandDateType { get; set; }
        public int DemandAddLeadTime { get; set; }
        public string DemandAddAction { get; set; }
        public int DemandChangeLeadTime { get; set; }
        public string DemandChangeAction { get; set; }
        public int DemandCancelLeadTime { get; set; }
        public string DemandCancelAction { get; set; }
        public int DemandNewLineLeadTime { get; set; }
        public string DemandNewLineAction { get; set; }
        public int DemandQtyChangeLeadTime { get; set; }
        public string DemandQtyChangeAction { get; set; }
        public int DemandChangeDateLeadTime { get; set; }
        public string DemandChangeDateAction { get; set; }
        public string TradingPartnerName { get; set; }
        public bool ResDelivery { get; set; }
        public bool SatDelivery { get; set; }
        public bool SatPickup { get; set; }
        public bool Hazmat { get; set; }
        public bool DocOnly { get; set; }
        public string RefNotes { get; set; }
        public bool ApplyChrg { get; set; }
        public decimal ChrgAmount { get; set; }
        public bool Cod { get; set; }
        public bool Codfreight { get; set; }
        public bool Codcheck { get; set; }
        public decimal Codamount { get; set; }
        public string GroundType { get; set; }
        public bool NotifyFlag { get; set; }
        public string NotifyEmail { get; set; }
        public bool DeclaredIns { get; set; }
        public decimal DeclaredAmt { get; set; }
        public int PeriodicityCode { get; set; }
        public bool ServSignature { get; set; }
        public bool ServAlert { get; set; }
        public bool ServHomeDel { get; set; }
        public string DeliveryType { get; set; }
        public DateTime? ServDeliveryDate { get; set; }
        public string ServPhone { get; set; }
        public string ServInstruct { get; set; }
        public bool ServRelease { get; set; }
        public string ServAuthNum { get; set; }
        public string ServRef1 { get; set; }
        public bool CommercialInvoice { get; set; }
        public string ServRef2 { get; set; }
        public bool ShipExprtDeclartn { get; set; }
        public string ServRef3 { get; set; }
        public bool CertOfOrigin { get; set; }
        public string ServRef4 { get; set; }
        public bool LetterOfInstr { get; set; }
        public string ServRef5 { get; set; }
        public bool HazardousShipment { get; set; }
        public bool OverrideCarrier { get; set; }
        public bool IntrntlShip { get; set; }
        public bool OverrideService { get; set; }
        public bool DemandUseCustomerValues { get; set; }
        public string TaxRegReason { get; set; }
        public int EarlyBuffer { get; set; }
        public string OrgRegCode { get; set; }
        public int LateBuffer { get; set; }
        public bool DemandUnitPriceDiff { get; set; }
        public string DemandUnitPriceDiffAction { get; set; }
        public bool ExcFromVal { get; set; }
        public bool AddressVal { get; set; }
        public bool DemandCheckForPart { get; set; }
        public string DemandCheckForPartAction { get; set; }
        public string Ffid { get; set; }
        public string Ffaddress1 { get; set; }
        public string Ffaddress2 { get; set; }
        public string Ffcity { get; set; }
        public string Ffstate { get; set; }
        public string Ffzip { get; set; }
        public string Ffcountry { get; set; }
        public string Ffcontact { get; set; }
        public string FfcompName { get; set; }
        public string FfphoneNum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool IndividualPackIds { get; set; }
        public int FfcountryNum { get; set; }
        public bool NonStdPkg { get; set; }
        public int DeliveryConf { get; set; }
        public bool AddlHdlgFlag { get; set; }
        public bool UpsquantumView { get; set; }
        public string UpsqvshipFromName { get; set; }
        public string Upsqvmemo { get; set; }
        public string Ffaddress3 { get; set; }
        public bool EtcaddrChg { get; set; }
        public bool IsAlternate { get; set; }
        public int MasterCustNum { get; set; }
        public string MasterShipToNum { get; set; }
        public bool DemandCheckForRev { get; set; }
        public string DemandCheckForRevAction { get; set; }
        public bool DemandCheckPartialShip { get; set; }
        public string DemandCheckShipAction { get; set; }
        public bool DemandCloseRejSkd { get; set; }
        public string DemandPricing { get; set; }
        public decimal PriceTolerance { get; set; }
        public bool CheckDateCapPromise { get; set; }
        public bool CheckConfirmCapPromise { get; set; }
        public bool CheckUpdateCapPromise { get; set; }
        public string DemandCapPromiseDate { get; set; }
        public string DemandCapPromiseAction { get; set; }
        public string DemandCapPromiseUpdate { get; set; }
        public bool OtsmartString { get; set; }
        public string LegalName { get; set; }
        public bool DemandCheckConfig { get; set; }
        public string DemandCheckCfgAction { get; set; }
        public bool WiwebShipTo { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agapartment { get; set; }
        public string AgextraStreetNumber { get; set; }
        public string Agfloor { get; set; }
        public string AggrossIncomeTaxId { get; set; }
        public string AglocationCode { get; set; }
        public string Agneighborhood { get; set; }
        public string AgprovinceCode { get; set; }
        public string Agstreet { get; set; }
        public string AgstreetNumber { get; set; }
        public string EntityUseCode { get; set; }
        public bool DemandCheckForRunOutPart { get; set; }
        public string DemandCheckForRunOutPartAction { get; set; }
        public string InexciseRegNumber { get; set; }
        public string Invatnumber { get; set; }
        public string Instregistration { get; set; }
        public string Mxcurp { get; set; }
        public string Mxmunicipio { get; set; }
        public string MxfederalId { get; set; }
        public string IntaxRegistrationId { get; set; }

        public virtual ShipToUd ShipToUd { get; set; }
    }
}