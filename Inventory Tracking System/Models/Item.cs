//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _22_46466_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]  
        public string ItemName { get; set; }

        [Required]  
        public int Quantity { get; set; }

        [Required]
        [Key]
        public int SupplierID { get; set; }
    }
}