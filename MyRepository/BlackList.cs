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
    
    public partial class BlackList
    {
        public long Id { get; set; }
        public string CardSerialNumber { get; set; }
        public string TicketSerialNumber { get; set; }
        public long ReasonId { get; set; }
        public Nullable<long> DeviceId { get; set; }
        public bool IsRestored { get; set; }
        public Nullable<long> RestoreReasonId { get; set; }
        public Nullable<long> RestoreDeviceId { get; set; }
        public Nullable<System.DateTime> RestoreDate { get; set; }
        public Nullable<long> RestoreOperId { get; set; }
        public bool AckReceived { get; set; }
        public Nullable<long> AckDeviceId { get; set; }
        public Nullable<System.DateTime> AckDate { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RV { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual Device Device { get; set; }
        public virtual Device Device1 { get; set; }
        public virtual BlackListReason BlackListReason { get; set; }
        public virtual Device Device2 { get; set; }
        public virtual BlackListRestoreReason BlackListRestoreReason { get; set; }
    }
}
