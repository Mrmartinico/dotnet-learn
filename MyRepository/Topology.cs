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
    
    public partial class Topology
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Topology()
        {
            this.LineTopology = new HashSet<LineTopology>();
            this.TopologyCalendarTopology = new HashSet<TopologyCalendarTopology>();
            this.Vehicle = new HashSet<Vehicle>();
            this.TopologyVersion = new HashSet<TopologyVersion>();
        }
    
        public long Id { get; set; }
        public string Description { get; set; }
        public long StatusId { get; set; }
        public long TopologyCategoryId { get; set; }
        public string SAEIVFileHash { get; set; }
        public byte[] RV { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineTopology> LineTopology { get; set; }
        public virtual Status Status { get; set; }
        public virtual TopologyCategory TopologyCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopologyCalendarTopology> TopologyCalendarTopology { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopologyVersion> TopologyVersion { get; set; }
    }
}
