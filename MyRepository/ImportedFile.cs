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
    
    public partial class ImportedFile
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public long FileTypeId { get; set; }
        public long DeviceId { get; set; }
        public Nullable<long> InsOperId { get; set; }
        public Nullable<System.DateTime> InsDate { get; set; }
        public byte[] RV { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual FileType FileType { get; set; }
    }
}