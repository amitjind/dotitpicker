﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FswarrCd
    {
        public string Company { get; set; }
        public string WarrantyCode { get; set; }
        public string WarrDescription { get; set; }
        public int MaterialDuration { get; set; }
        public int LaborDuration { get; set; }
        public int MiscDuration { get; set; }
        public string MaterialMod { get; set; }
        public string LaborMod { get; set; }
        public string MiscMod { get; set; }
        public string CommentText { get; set; }
        public bool OnSite { get; set; }
        public bool MatCovered { get; set; }
        public bool LabCovered { get; set; }
        public bool MiscCovered { get; set; }
        public bool GlobalFswarrCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SendToFsa { get; set; }
    }
}
