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
    
    public partial class ProfileCard
    {
        public long CardId { get; set; }
        public long ProfileId { get; set; }
        public System.DateTime Endvalidity { get; set; }
        public long InsOperId { get; set; }
        public System.DateTime InsDate { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RV { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual Profile Profile { get; set; }
    }
}