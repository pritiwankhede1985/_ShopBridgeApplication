//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopBridge.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ItemMaster
    {
        public int ItemId { get; set; }
        [Required]
        public string ItenName { get; set; }
        [Required]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Quantity must be a number")]
        public int Quantity { get; set; }
        [Required]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Price must be a number")]
        public double Price { get; set; }
        public Nullable<int> Dicount { get; set; }
        public string ItemType { get; set; }
    }
}
