﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImboxNumber
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public string BoxNum { get; set; }
        public string Description { get; set; }
        public string ElectronicCode { get; set; }
        public string Comment { get; set; }
        public bool Inactive { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string AggregateBoxNum { get; set; }
    }
}