using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poppi.Models
{
    public class CategoryDetail
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category Name Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and minimum 5 and maximum 100 characters")]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class ProductDetail
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int AmountOfChamps { get; set; }
        public string Region { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        public int AmountOfSkins { get; set; }
        public string SkinDetails { get; set; }
        public string ExtraAccountDetails { get; set; }
        public int CategoryID { get; set; }
        [Range(typeof(decimal), "1", "200000", ErrorMessage ="invalid price")]
        public Nullable<decimal> Price { get; set; }
    }
}