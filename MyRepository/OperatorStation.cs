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
    
    public partial class OperatorStation
    {
        public long Id { get; set; }
        public long OperatorId { get; set; }
        public long StationId { get; set; }
        public System.DateTime ModDate { get; set; }
        public long ModOperId { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
    
        public virtual Operator Operator { get; set; }
        public virtual Station Station { get; set; }
    }
}
