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
    
    public partial class CoinTypeSale
    {
        public long Id { get; set; }
        public long SaleId { get; set; }
        public int CoinValue { get; set; }
        public int IntroducedPieces { get; set; }
        public int RecycledPieces { get; set; }
        public int EncashedPieces { get; set; }
        public int ReturnedPieces { get; set; }
        public int TotalPiecesIntoRecycle { get; set; }
        public int TotalPiecesIntoCashbox { get; set; }
        public System.DateTime InsDate { get; set; }
        public long InsOperId { get; set; }
        public byte[] RV { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<long> ModOperId { get; set; }
    
        public virtual Sale Sale { get; set; }
    }
}
