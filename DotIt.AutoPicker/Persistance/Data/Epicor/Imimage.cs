﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imimage
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ImageId { get; set; }
        public string ImageFileName { get; set; }
        public string ImageFileThumbnail { get; set; }
        public string ImageCategoryId { get; set; }
        public string ImageSubCategoryId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int FileSize { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public string FileType { get; set; }
        public bool GlobalImage { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Reference4 { get; set; }
        public string Reference5 { get; set; }
        public Guid ThumbnailSysRowId { get; set; }
        public Guid ImageSysRowId { get; set; }
    }
}
