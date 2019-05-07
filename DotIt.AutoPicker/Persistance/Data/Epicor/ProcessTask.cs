﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProcessTask
    {
        public ProcessTask()
        {
            ProcessTaskParam = new HashSet<ProcessTaskParam>();
        }

        public string SystemCode { get; set; }
        public string ProcessId { get; set; }
        public int SysTaskNum { get; set; }
        public string TaskDescription { get; set; }
        public string TaskType { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        public string SubmitUser { get; set; }
        public string TaskStatus { get; set; }
        public string Company { get; set; }
        public string AgentId { get; set; }
        public long AgentSchedNum { get; set; }
        public int AgentTaskNum { get; set; }
        public string RunProcedure { get; set; }
        public string InitiatorSource { get; set; }
        public string ActivityMsg { get; set; }
        public bool History { get; set; }
        public string TaskNote { get; set; }
        public DateTime? LastActivityOn { get; set; }
        public string UserPidinfo { get; set; }
        public string SourceDll { get; set; }
        public int Sequence { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ProcessSet ProcessSet { get; set; }
        public virtual ICollection<ProcessTaskParam> ProcessTaskParam { get; set; }
    }
}