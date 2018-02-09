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
    
    public partial class ZonalPrice
    {
        public long Id { get; set; }
        public long PriceId { get; set; }
        public int Value { get; set; }
        public Nullable<long> OriginId { get; set; }
        public Nullable<long> DestinationId { get; set; }
        public Nullable<long> ViaId { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual FareZone FareZone { get; set; }
        public virtual FareZone FareZone1 { get; set; }
        public virtual FareZone FareZone2 { get; set; }
        public virtual Price Price { get; set; }
    }
}