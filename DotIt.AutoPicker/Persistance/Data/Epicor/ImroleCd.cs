﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImroleCd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RoleCode { get; set; }
        public string RoleDescription { get; set; }
        public bool Inactive { get; set; }
        public bool Commissionable { get; set; }
        public string ResourceGrpId { get; set; }
        public bool UseResGrp { get; set; }
        public bool TimeApprover { get; set; }
        public bool ExpenseApprover { get; set; }
        public bool EmployeeRole { get; set; }
        public int ApprovalSupervisorLevel { get; set; }
        public bool SupervisorRole { get; set; }
        public bool ProjectMgrRole { get; set; }
        public bool GlobalRoleCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}