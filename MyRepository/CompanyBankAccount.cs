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
    
    public partial class CompanyBankAccount
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public string ICS { get; set; }
        public Nullable<long> ToponymId { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Province { get; set; }
        public string CountryCd { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RV { get; set; }
        public string Description { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
