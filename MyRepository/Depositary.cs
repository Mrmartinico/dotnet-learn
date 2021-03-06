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
    
    public partial class Depositary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Depositary()
        {
            this.Device = new HashSet<Device>();
        }
    
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Code { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Province { get; set; }
        public string CountryCd { get; set; }
        public string City { get; set; }
        public string VAT { get; set; }
        public System.DateTime InsDate { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
        public long InsOperId { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Device { get; set; }
    }
}
