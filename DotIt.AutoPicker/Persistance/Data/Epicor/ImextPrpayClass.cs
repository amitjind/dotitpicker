﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImextPrpayClass
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PayClassId { get; set; }
        public string Description { get; set; }
        public bool HolidayOt { get; set; }
        public bool VacOt { get; set; }
        public bool SickOt { get; set; }
        public bool Pto { get; set; }
        public decimal OtperDay { get; set; }
        public decimal OtperWeek { get; set; }
        public decimal DtperDay { get; set; }
        public decimal DtperWeek { get; set; }
        public string PtmonFri { get; set; }
        public string Ptsat { get; set; }
        public string Ptsun { get; set; }
        public string Ptholiday { get; set; }
        public int HolExemptDays { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PtholLabor { get; set; }
        public bool ExtPrperDayAllFreq { get; set; }
    }
}
