//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOG.AppCode.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeekDayTiming
    {
        public long Id { get; set; }
        public byte WeekDayId { get; set; }
        public string DayName { get; set; }
        public bool IsWeekDayActive { get; set; }
        public Nullable<bool> IsTimingActive { get; set; }
        public Nullable<short> HourStart { get; set; }
        public Nullable<short> HourEnd { get; set; }
        public Nullable<short> MinuteStart { get; set; }
        public Nullable<short> MinutesEnd { get; set; }
        public Nullable<short> FromHours { get; set; }
        public Nullable<short> FromMinutes { get; set; }
        public Nullable<short> ToHours { get; set; }
        public Nullable<short> ToMinutes { get; set; }
        public Nullable<short> TimePeriodId { get; set; }
    }
}