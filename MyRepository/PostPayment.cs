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
    
    public partial class PostPayment
    {
        public long Id { get; set; }
        public long SaleDetailId { get; set; }
        public long PostPaymentConfigId { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
        public byte[] RV { get; set; }
    
        public virtual PostPaymentConfig PostPaymentConfig { get; set; }
        public virtual PostPaymentConfig PostPaymentConfig1 { get; set; }
        public virtual SaleDetail SaleDetail { get; set; }
    }
}