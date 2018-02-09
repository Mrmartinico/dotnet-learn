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
    
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.AuditLogHeader = new HashSet<AuditLogHeader>();
            this.BlackList = new HashSet<BlackList>();
            this.BlackList1 = new HashSet<BlackList>();
            this.BlackList2 = new HashSet<BlackList>();
            this.DeviceConfiguration = new HashSet<DeviceConfiguration>();
            this.ExportedFile = new HashSet<ExportedFile>();
            this.GreenList = new HashSet<GreenList>();
            this.GreenList1 = new HashSet<GreenList>();
            this.GreenListErrorOnMedia = new HashSet<GreenListErrorOnMedia>();
            this.GreyList = new HashSet<GreyList>();
            this.GreyList1 = new HashSet<GreyList>();
            this.GreyListErrorOnMedia = new HashSet<GreyListErrorOnMedia>();
            this.GreyListErrorOnMedia1 = new HashSet<GreyListErrorOnMedia>();
            this.PublishedContext = new HashSet<PublishedContext>();
            this.Session = new HashSet<Session>();
            this.StockEntity = new HashSet<StockEntity>();
        }
    
        public long Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public long DeviceTypeId { get; set; }
        public Nullable<long> DeviceGroupId { get; set; }
        public Nullable<long> VehicleId { get; set; }
        public Nullable<long> StationId { get; set; }
        public Nullable<long> DepositaryId { get; set; }
        public byte[] RV { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> DeviceSubTypeId { get; set; }
        public Nullable<long> LegalEntityId { get; set; }
        public Nullable<long> NetworkId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditLogHeader> AuditLogHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlackList> BlackList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlackList> BlackList1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlackList> BlackList2 { get; set; }
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Depositary Depositary { get; set; }
        public virtual EquipmentGroup EquipmentGroup { get; set; }
        public virtual DeviceSubType DeviceSubType { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public virtual Stop Stop { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceConfiguration> DeviceConfiguration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportedFile> ExportedFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreenList> GreenList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreenList> GreenList1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreenListErrorOnMedia> GreenListErrorOnMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyList> GreyList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyList> GreyList1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyListErrorOnMedia> GreyListErrorOnMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreyListErrorOnMedia> GreyListErrorOnMedia1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublishedContext> PublishedContext { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockEntity> StockEntity { get; set; }
    }
}