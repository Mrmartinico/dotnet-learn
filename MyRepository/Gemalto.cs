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
    
    public partial class Gemalto
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long CardId { get; set; }
        public Nullable<long> CustomerProfileId { get; set; }
        public Nullable<long> CardImageItemId { get; set; }
        public Nullable<long> ConfigurationTypeId { get; set; }
        public Nullable<long> ExportStatusId { get; set; }
        public Nullable<long> ErrorTypeId { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public System.DateTime InsDate { get; set; }
        public System.DateTime ModDate { get; set; }
        public bool IsDeleted { get; set; }
        public long InsOperId { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public byte[] RV { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual CardImageItem CardImageItem { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerProfile CustomerProfile { get; set; }
        public virtual GemaltoConfigurationType GemaltoConfigurationType { get; set; }
        public virtual GemaltoErrorType GemaltoErrorType { get; set; }
        public virtual GemaltoExportStatus GemaltoExportStatus { get; set; }
    }
}