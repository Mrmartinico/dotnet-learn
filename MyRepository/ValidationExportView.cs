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
    
    public partial class ValidationExportView
    {
        public long DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceDescription { get; set; }
        public int SessionNumber { get; set; }
        public string ProductCommercialName { get; set; }
        public System.DateTime ValidationDate { get; set; }
        public int ValidationNumber { get; set; }
        public int TripCounterBeforeValidation { get; set; }
        public int TripCounterAfterValidation { get; set; }
        public Nullable<long> VehicleId { get; set; }
        public string VehicleDescription { get; set; }
        public string LineNumber { get; set; }
        public string LineDescription { get; set; }
        public string ItineraryDescription { get; set; }
        public Nullable<long> FareStopId { get; set; }
        public string FareStopDescription { get; set; }
        public System.DateTime ContractValidityEndDate { get; set; }
        public Nullable<System.DateTime> ProductStartValidity { get; set; }
        public Nullable<System.DateTime> ProductEndOfValidity { get; set; }
    }
}
