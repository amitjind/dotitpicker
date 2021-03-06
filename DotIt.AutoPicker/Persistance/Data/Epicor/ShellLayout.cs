﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShellLayout
    {
        public ShellLayout()
        {
            ShellLayoutPersonal = new HashSet<ShellLayoutPersonal>();
        }

        public string TenantId { get; set; }
        public string LayoutId { get; set; }
        public string AuthorId { get; set; }
        public DateTime DateModified { get; set; }
        public string ShellHomePage { get; set; }
        public string ShellUserOptions { get; set; }
        public string FavoriteItems { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SecCode { get; set; }
        public bool Published { get; set; }
        public string HomePageType { get; set; }
        public string SubType { get; set; }
        public string LayoutDescription { get; set; }

        public virtual ICollection<ShellLayoutPersonal> ShellLayoutPersonal { get; set; }
    }
}
