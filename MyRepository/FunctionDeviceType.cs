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
    
    public partial class FunctionDeviceType
    {
        public long Id { get; set; }
        public long FunctionId { get; set; }
        public long DeviceTypeId { get; set; }
        public string CodeExt { get; set; }
        public Nullable<int> LevelRead { get; set; }
        public Nullable<int> LevelWrite { get; set; }
        public System.DateTime ModDate { get; set; }
        public long ModOperId { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
    
        public virtual DeviceType DeviceType { get; set; }
        public virtual Function Function { get; set; }
    }
}
