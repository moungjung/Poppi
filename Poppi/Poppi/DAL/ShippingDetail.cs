//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poppi.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShippingDetail
    {
        public int ShippingDetailID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public string ShippingEmailAddress { get; set; }
        public int OrderId { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentType { get; set; }
    
        public virtual Member Member { get; set; }
    }
}