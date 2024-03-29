﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfsSyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int StartContractNum { get; set; }
        public int StartServiceCallNum { get; set; }
        public int ExpireHorizon { get; set; }
        public bool PrintPrice { get; set; }
        public string CallProdCode { get; set; }
        public string CallJobPrefix { get; set; }
        public bool ContractStartup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int RenewalPeriod { get; set; }
    }
}
