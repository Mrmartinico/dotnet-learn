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
    
    public partial class Alarm
    {
        public long Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public long AlarmMessageId { get; set; }
        public long AlarmStatusId { get; set; }
        public long OpenSessionId { get; set; }
        public Nullable<long> CloseSessionId { get; set; }
        public Nullable<System.DateTime> InsDate { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public byte[] RV { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> InsOperId { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual AlarmMessage AlarmMessage { get; set; }
        public virtual AlarmStatus AlarmStatus { get; set; }
        public virtual Session Session { get; set; }
        public virtual Session Session1 { get; set; }
    }
}
