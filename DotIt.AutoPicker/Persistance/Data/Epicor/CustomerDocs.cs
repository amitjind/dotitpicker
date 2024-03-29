﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CustomerDocs
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string AltTradingPartnerName { get; set; }
        public bool TestRecord { get; set; }
        public bool UseCustomerDefaults { get; set; }
        public bool CheckForPart { get; set; }
        public bool UseCustPart { get; set; }
        public bool OutBoundDocReq { get; set; }
        public string MapId { get; set; }
        public string AcceptType { get; set; }
        public string DocDirection { get; set; }
        public string OutboundDocName { get; set; }
        public bool DeleteCurrentReleases { get; set; }
        public bool UsePartUpc { get; set; }
        public bool OutboundManual { get; set; }
        public bool OutboundAutomatic { get; set; }
        public string EdipartValidation { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PartOptionAvailList { get; set; }
        public string PartOptionSelList { get; set; }
    }
}
