﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImagemissionPoint
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EmissionPointId { get; set; }
        public string TranDocTypeId { get; set; }
        public string DocumentLetter { get; set; }
        public string InvoicingPoint { get; set; }
        public string PrintingControlType { get; set; }
        public string LegalNumberId { get; set; }
        public string AltEmissionPointId { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
