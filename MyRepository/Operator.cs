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
    
    public partial class Operator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operator()
        {
            this.Control = new HashSet<Control>();
            this.GreenList = new HashSet<GreenList>();
            this.GreenListErrorOnMedia = new HashSet<GreenListErrorOnMedia>();
            this.GreyList = new HashSet<GreyList>();
            this.GreyListErrorOnMedia = new HashSet<GreyListErrorOnMedia>();
            this.GreyListErrorOnMedia1 = new HashSet<GreyListErrorOnMedia>();
            this.OperatorOperatorProfile = new HashSet<OperatorOperatorProfile>();
            this.OperatorStation = new HashSet<OperatorStation>();
            this.RegularizedFine = new HashSet<RegularizedFine>();
            this.Sale = new HashSet<Sale>();
            this.Session = new HashSet<Session>();
            this.StockEntity = new HashSet<StockEntity>();
        }
    
        public long Id { get; set; }
        public long Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> GenderId { get; set; }
        public long CompanyId { get; set; }
        public Nullable<long> CardId { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string PinCode { get; set; }
        public bool IsEnabled { get; set; }
        public Nullable<long> LegalEntityId { get; set; }
        public bool CreationCard { get; set; }
        public Nullable<System.DateTime> ExpireCardDate { get; set; }
        public Nullable<long> OperatorPasswordId { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public short FailedLogin { get; set; }
        public bool IsLocked { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RV { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Control { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreenList> GreenList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreenListErrorOnMedia> GreenListErrorOnMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyList> GreyList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyListErrorOnMedia> GreyListErrorOnMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyListErrorOnMedia> GreyListErrorOnMedia1 { get; set; }
        public virtual OperatorPassword OperatorPassword { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatorOperatorProfile> OperatorOperatorProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatorStation> OperatorStation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegularizedFine> RegularizedFine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockEntity> StockEntity { get; set; }
    }
}
