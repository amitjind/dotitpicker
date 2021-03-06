﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcInputsLayerDetail
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public string ImageLayerId { get; set; }
        public int LayerSeq { get; set; }
        public string LayerName { get; set; }
        public string LayerDesc { get; set; }
        public int Zindex { get; set; }
        public string ImageId { get; set; }
        public string FileType { get; set; }
        public string Category { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PcInputsLayerHeader PcInputsLayerHeader { get; set; }
    }
}
