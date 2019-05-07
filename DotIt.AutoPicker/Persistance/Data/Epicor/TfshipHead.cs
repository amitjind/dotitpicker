﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TfshipHead
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipViaCode { get; set; }
        public string ShipPerson { get; set; }
        public string EntryPerson { get; set; }
        public string ShipLog { get; set; }
        public string LabelComment { get; set; }
        public string ShipComment { get; set; }
        public string Plant { get; set; }
        public string TrackingNumber { get; set; }
        public string LegalNumber { get; set; }
        public bool ExternalDeliveryNote { get; set; }
        public string ExternalId { get; set; }
        public bool Directtransfer { get; set; }
        public string ToPlant { get; set; }
        public bool Shipped { get; set; }
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
        public string MftransNum { get; set; }
        public string MfcallTag { get; set; }
        public string MfpickupNum { get; set; }
        public decimal MfdiscFreight { get; set; }
        public string Mftemplate { get; set; }
        public bool Mfuse3B { get; set; }
        public string Mf3baccount { get; set; }
        public decimal MfdimWeight { get; set; }
        public string Mfzone { get; set; }
        public decimal MffreightAmt { get; set; }
        public decimal MfotherAmt { get; set; }
        public bool Mfoversized { get; set; }
        public string ShipStatus { get; set; }
        public string ShipGroup { get; set; }
        public decimal Weight { get; set; }
        public string PkgCode { get; set; }
        public string PkgClass { get; set; }
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
        public string ServRef2 { get; set; }
        public string ServRef3 { get; set; }
        public string ServRef4 { get; set; }
        public string ServRef5 { get; set; }
        public string BinNum { get; set; }
        public int Bolnum { get; set; }
        public bool CommercialInvoice { get; set; }
        public int Bolline { get; set; }
        public bool ShipExprtDeclartn { get; set; }
        public bool CertOfOrigin { get; set; }
        public bool LetterOfInstr { get; set; }
        public bool HazardousShipment { get; set; }
        public string PayFlag { get; set; }
        public string PayAccount { get; set; }
        public string PayBtaddress1 { get; set; }
        public string PayBtaddress2 { get; set; }
        public string PayBtcity { get; set; }
        public string PayBtstate { get; set; }
        public string PayBtzip { get; set; }
        public string PayBtcountry { get; set; }
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
        public bool IntrntlShip { get; set; }
        public bool IndividualPackIds { get; set; }
        public string Ffaddress3 { get; set; }
        public int DeliveryConf { get; set; }
        public bool AddlHdlgFlag { get; set; }
        public bool NonStdPkg { get; set; }
        public int FfcountryNum { get; set; }
        public string PayBtaddress3 { get; set; }
        public int PayBtcountryNum { get; set; }
        public string PayBtphone { get; set; }
        public string WayBillNbr { get; set; }
        public string FreightedShipViaCode { get; set; }
        public bool UpsquantumView { get; set; }
        public string UpsqvshipFromName { get; set; }
        public string Upsqvmemo { get; set; }
        public decimal PkgLength { get; set; }
        public decimal PkgWidth { get; set; }
        public decimal PkgHeight { get; set; }
        public bool PhantomPack { get; set; }
        public string PkgSizeUom { get; set; }
        public string WeightUom { get; set; }
        public string TranDocTypeId { get; set; }
        public bool DocumentPrinted { get; set; }
        public string DeviceUom { get; set; }
        public string ManifestSizeUom { get; set; }
        public string ManifestWtUom { get; set; }
        public decimal ManifestWeight { get; set; }
        public decimal ManifestLength { get; set; }
        public decimal ManifestWidth { get; set; }
        public decimal ManifestHeight { get; set; }
        public string WarehouseCode { get; set; }
        public bool AutoPrintReady { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string AgauthorizationCode { get; set; }
        public DateTime? AgauthorizationDate { get; set; }
        public string AgcarrierCuit { get; set; }
        public string AgdocumentLetter { get; set; }
        public string AginvoicingPoint { get; set; }
        public string AglegalNumber { get; set; }
        public string AgprintingControlType { get; set; }
        public string AgtrackLicense { get; set; }
        public string AgshippingWay { get; set; }
        public bool Agcotmark { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string DigitalSignature { get; set; }
        public DateTime? SignedOn { get; set; }
        public string SignedBy { get; set; }
        public DateTime? FirstPrintDate { get; set; }
        public int DocCopyNum { get; set; }
    }
}