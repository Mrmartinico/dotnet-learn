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
    
    public partial class CustomerBankAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerBankAccount()
        {
            this.CustomerPayer = new HashSet<CustomerPayer>();
            this.PaymentOrder = new HashSet<PaymentOrder>();
        }
    
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string Description { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public Nullable<long> ToponymId { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Province { get; set; }
        public string CountryCd { get; set; }
        public bool IsDisabled { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RV { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPayer> CustomerPayer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentOrder> PaymentOrder { get; set; }
    }
}
