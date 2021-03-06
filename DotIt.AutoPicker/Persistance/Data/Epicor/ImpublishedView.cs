﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpublishedView
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string DynamicQueryId { get; set; }
        public string ProductId { get; set; }
        public string DefinitionId { get; set; }
        public bool Approved { get; set; }
        public string UserId { get; set; }
        public string GlbCompany { get; set; }
        public string ViewId { get; set; }
        public string Caption { get; set; }
        public bool InstallView { get; set; }
        public string ImageName { get; set; }
        public bool System { get; set; }
        public bool IsShared { get; set; }
        public string PublishedBy { get; set; }
        public string ViewType { get; set; }
        public string Cgccode { get; set; }
        public string Pvgroup { get; set; }
        public string Description { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
