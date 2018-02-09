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
    
    public partial class AuditLogHeader
    {
        public long Id { get; set; }
        public long DeviceTypeId { get; set; }
        public long DeviceId { get; set; }
        public int DevicePosition { get; set; }
        public string DeviceSerialNumber { get; set; }
        public Nullable<long> VehicleId { get; set; }
        public int SessionNumber { get; set; }
        public System.DateTime SessionStartDate { get; set; }
        public Nullable<System.DateTime> SessionEndDate { get; set; }
        public long OperatorId { get; set; }
        public string SoftwareVersion { get; set; }
        public string ConfigVersion { get; set; }
        public string SamSerialNumber { get; set; }
        public string BlackListVersion { get; set; }
        public string GreyListVersion { get; set; }
        public string GreenListVersion { get; set; }
        public Nullable<long> VehicleTypeId { get; set; }
        public string OperatorListVersion { get; set; }
        public byte[] RV { get; set; }
        public System.DateTime InsDate { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
        public long InsOperId { get; set; }
        public Nullable<long> StopId { get; set; }
    
        public virtual Device Device { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public virtual Stop Stop { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}
