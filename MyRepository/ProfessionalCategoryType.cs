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
    
    public partial class ProfessionalCategoryType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProfessionalCategoryType()
        {
            this.CustomerProfessionalCategory = new HashSet<CustomerProfessionalCategory>();
        }
    
        public long Id { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public long ModOperId { get; set; }
        public System.DateTime ModDate { get; set; }
        public byte[] RV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerProfessionalCategory> CustomerProfessionalCategory { get; set; }
    }
}