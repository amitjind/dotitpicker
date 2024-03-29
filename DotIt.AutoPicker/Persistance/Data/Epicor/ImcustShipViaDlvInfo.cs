﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcustShipViaDlvInfo
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string ShipViaCode { get; set; }
        public int DemandDeliveryDays { get; set; }
        public int PeriodicityCode { get; set; }
        public string DemandDateType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
