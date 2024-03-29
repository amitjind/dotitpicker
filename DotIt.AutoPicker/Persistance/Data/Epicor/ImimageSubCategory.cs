﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImimageSubCategory
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ImageCategoryId { get; set; }
        public string ImageSubCategoryId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int MaxSize { get; set; }
    }
}
