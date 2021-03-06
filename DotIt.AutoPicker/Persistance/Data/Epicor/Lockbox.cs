﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Lockbox
    {
        public Lockbox()
        {
            LockboxCheck = new HashSet<LockboxCheck>();
        }

        public string Company { get; set; }
        public string GroupId { get; set; }
        public string LockboxId { get; set; }
        public string Description { get; set; }
        public string BankFilePath { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public bool ReadyToProcess { get; set; }
        public DateTime? TransmissionDate { get; set; }
        public int TransmissionTime { get; set; }
        public string ErrorMsg { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual LockboxGroup LockboxGroup { get; set; }
        public virtual ICollection<LockboxCheck> LockboxCheck { get; set; }
    }
}
