﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Impdmsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PdmexportDir { get; set; }
        public string PdmimportDir { get; set; }
        public string DocExportDir { get; set; }
        public string DocImportDir { get; set; }
        public string EcogroupId { get; set; }
        public string RevisionNum { get; set; }
        public string SearchWord { get; set; }
        public int FileNum { get; set; }
        public string PartPrefix { get; set; }
        public string BomPrefix { get; set; }
        public string DocPrefix { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Plmrevision { get; set; }
    }
}
