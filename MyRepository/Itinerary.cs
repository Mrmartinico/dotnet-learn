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
    
    public partial class Itinerary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Itinerary()
        {
            this.Control = new HashSet<Control>();
            this.ItineraryStop = new HashSet<ItineraryStop>();
            this.Travel = new HashSet<Travel>();
        }
    
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsReverseDirection { get; set; }
        public long LineTopologyId { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHidden { get; set; }
        public byte[] RV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Control { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItineraryStop> ItineraryStop { get; set; }
        public virtual LineTopology LineTopology { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Travel> Travel { get; set; }
    }
}
