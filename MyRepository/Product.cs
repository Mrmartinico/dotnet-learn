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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.FareProductItem = new HashSet<FareProductItem>();
            this.InventoryItem = new HashSet<InventoryItem>();
        }
    
        public long Id { get; set; }
        public long Code { get; set; }
        public string Description { get; set; }
        public long CompanyId { get; set; }
        public Nullable<int> PeriodCount { get; set; }
        public Nullable<int> AntiPassBackDelay { get; set; }
        public Nullable<int> DelayForConnection { get; set; }
        public Nullable<int> TripDuration { get; set; }
        public string AccountingCode { get; set; }
        public int ShowOrder { get; set; }
        public Nullable<long> PeriodTypeId { get; set; }
        public Nullable<long> ValidityTypeId { get; set; }
        public long ProductFamilyId { get; set; }
        public long InsOperId { get; set; }
        public System.DateTime InsDate { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FareProductItem> FareProductItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryItem> InventoryItem { get; set; }
        public virtual PeriodType PeriodType { get; set; }
        public virtual ProductFamily ProductFamily { get; set; }
        public virtual ValidityType ValidityType { get; set; }
    }
}