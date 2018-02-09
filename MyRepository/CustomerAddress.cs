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
    
    public partial class CustomerAddress
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long AddressTypeId { get; set; }
        public Nullable<long> ToponymTypeId { get; set; }
        public string Address { get; set; }
        public string AddressComplement { get; set; }
        public string AddressComplement2 { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Province { get; set; }
        public string Hamlet { get; set; }
        public string CountryCd { get; set; }
        public bool Npai { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public byte[] RV { get; set; }
    
        public virtual AddressType AddressType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ToponymType ToponymType { get; set; }
    }
}
