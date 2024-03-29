﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EmpBasic
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EmgPhone { get; set; }
        public int Shift { get; set; }
        public decimal LaborRate { get; set; }
        public bool Payroll { get; set; }
        public bool PrsetupReq { get; set; }
        public string EmpStatus { get; set; }
        public string ExpenseCode { get; set; }
        public string PhotoFile { get; set; }
        public string Jcdept { get; set; }
        public string EmgContact { get; set; }
        public string SupervisorId { get; set; }
        public int CountryNum { get; set; }
        public bool ServTech { get; set; }
        public string EmailAddress { get; set; }
        public string DcdUserId { get; set; }
        public bool ProductionWorker { get; set; }
        public bool MaterialHandler { get; set; }
        public bool ShopSupervisor { get; set; }
        public bool CanReportQty { get; set; }
        public bool CanOverrideJob { get; set; }
        public bool CanRequestMaterial { get; set; }
        public bool CanReportScrapQty { get; set; }
        public bool CanReportNcqty { get; set; }
        public bool ShipRecv { get; set; }
        public string CnvEmpId { get; set; }
        public bool WarehouseManager { get; set; }
        public bool CanOverrideAllocations { get; set; }
        public bool AllowDirLbr { get; set; }
        public bool ContractEmp { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public string TimeWfgroupId { get; set; }
        public bool ExpenseEntryAllowed { get; set; }
        public string ExpenseWfgroupId { get; set; }
        public int ExpenseVendorNum { get; set; }
        public int PerConId { get; set; }
        public bool SyncNameToPerCon { get; set; }
        public bool SyncAddressToPerCon { get; set; }
        public bool SyncPhoneToPerCon { get; set; }
        public bool SyncEmailToPerCon { get; set; }
        public bool CanEnterIndirectTime { get; set; }
        public bool CanEnterProductionTime { get; set; }
        public bool CanEnterProjectTime { get; set; }
        public bool CanEnterServiceTime { get; set; }
        public bool CanEnterSetupTime { get; set; }
        public bool TimeAutoApprove { get; set; }
        public bool ExpenseAutoApprove { get; set; }
        public string MobileUserPassword { get; set; }
        public bool AllowIndirect { get; set; }
        public bool AllowProduction { get; set; }
        public bool AllowProject { get; set; }
        public bool AllowService { get; set; }
        public bool AllowSetup { get; set; }
        public string DefaultLaborTypePseudo { get; set; }
        public string DefaultTimeTypCd { get; set; }
        public string DefaultIndirectCode { get; set; }
        public string DefaultExpenseCode { get; set; }
        public string DefaultResourceGrpId { get; set; }
        public string DefaultResourceId { get; set; }
        public decimal DefaultLaborHrs { get; set; }
        public string DefaultExpCurrencyCode { get; set; }
        public string DefaultClaimCurrencyCode { get; set; }
        public int DefaultPmuid { get; set; }
        public string DefaultTaxRegionCode { get; set; }
        public bool DefaultTaxIncluded { get; set; }
        public bool ExpenseAdvReqAllowed { get; set; }
        public string ExpenseAdvReqWfgroupId { get; set; }
        public bool ExpenseAdvReqAutoApprove { get; set; }
        public string MobileResourceId { get; set; }
        public bool AllowAsAltRemitTo { get; set; }
        public string UserNameInJdf { get; set; }
        public byte[] EmployeePhoto { get; set; }
        public bool ExternalMes { get; set; }
        public bool PermitScrap { get; set; }
        public bool PermitDown { get; set; }
        public bool PermitHelp { get; set; }
        public bool PermitJobControl { get; set; }
        public bool PermitNextJobControl { get; set; }
        public bool PermitManualSqc { get; set; }
        public bool PermitVariableSqc { get; set; }
        public bool PermitAttributeSqc { get; set; }
        public bool PermitMaterialLot { get; set; }
        public bool PermitSetupMaterial { get; set; }
        public bool PermitCavities { get; set; }
        public bool PermitPercentRegrind { get; set; }
        public bool PermitSaveProfile { get; set; }
        public bool PermitCalibration { get; set; }
        public bool PermitMachinePm { get; set; }
        public bool PermitToolPm { get; set; }
        public bool PermitLanguage { get; set; }
        public bool PermitPreferences { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool DisallowTimeEntry { get; set; }
        public bool PkgInboundAllowed { get; set; }
        public bool PkgOutboundAllowed { get; set; }
        public bool PkgInventoryAllowed { get; set; }
        public bool PkgManufacturingAllowed { get; set; }
        public bool PkgQualityAllowed { get; set; }
        public string ImageId { get; set; }
        public bool PkgMasterMixedPrint { get; set; }
        public bool PkgSuppressPrintMessages { get; set; }
        public string PayrollValuesForHcm { get; set; }
        public bool SendToFsa { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
