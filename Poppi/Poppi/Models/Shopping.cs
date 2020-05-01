using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poppi.Models
{
    public class Shippingdetail
    {
        public int ShippingDetailID { get; set; }
        [Required]
        public Nullable<int> MemberID { get; set; }
        [Required]
        public string ShippingEmailAddress { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public decimal AmountPaid { get; set; }
        [Required]
        public string PaymentType { get; set; }
    }
}