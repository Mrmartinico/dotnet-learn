//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeRange
    {
        public long Id { get; set; }
        public long TimeTableId { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public Nullable<long> WeekDayId { get; set; }
        public Nullable<long> CalendarId { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual Calendar Calendar { get; set; }
        public virtual TimeTable TimeTable { get; set; }
        public virtual WeekDay WeekDay { get; set; }
    }
}
