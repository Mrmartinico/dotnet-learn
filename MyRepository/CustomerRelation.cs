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
    
    public partial class CustomerRelation
    {
        public long Id { get; set; }
        public long CustomerId1 { get; set; }
        public long CustomerId2 { get; set; }
        public long RelationTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RV { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual RelationType RelationType { get; set; }
    }
}