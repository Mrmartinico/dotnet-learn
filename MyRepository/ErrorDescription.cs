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
    
    public partial class ErrorDescription
    {
        public long Id { get; set; }
        public long ErrorId { get; set; }
        public string LanguageCode { get; set; }
        public string Transl { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public byte[] RV { get; set; }
    
        public virtual Error Error { get; set; }
        public virtual Language Language { get; set; }
    }
}
