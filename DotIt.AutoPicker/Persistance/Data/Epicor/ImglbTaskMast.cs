﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbTaskMast
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool AnyApprover { get; set; }
        public int ApprovalSupervisorLevel { get; set; }
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public bool Mandatory { get; set; }
        public bool PasswordReq { get; set; }
        public int PriorityCode { get; set; }
        public string RoleCode { get; set; }
        public bool SendAlertComplete { get; set; }
        public bool SendAlertCreate { get; set; }
        public bool SubmitTask { get; set; }
        public string TaskComment { get; set; }
        public string TaskDescription { get; set; }
        public string TaskId { get; set; }
        public string TypeCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaskId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaskMast { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
