﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VenPpupsemail
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int Upsqvseq { get; set; }
        public string EmailAddress { get; set; }
        public bool ShipmentNotify { get; set; }
        public bool FailureNotify { get; set; }
        public bool DeliveryNotify { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
