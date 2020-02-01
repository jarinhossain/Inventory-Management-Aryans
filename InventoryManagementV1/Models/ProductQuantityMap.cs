//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagementV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductQuantityMap
    {
        public int Id { get; set; }
        public Nullable<int> Color_Id { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> Material_Id { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public Nullable<int> Size_Group_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public Nullable<double> Price { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
        public virtual SizeGroup SizeGroup { get; set; }
    }
}
