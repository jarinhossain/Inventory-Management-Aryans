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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductQuantityMap()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Color_Id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Material_Id { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public Nullable<int> Size_Group_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_On { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
        public virtual SizeGroup SizeGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
