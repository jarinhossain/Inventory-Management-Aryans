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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductQuantityMaps = new HashSet<ProductQuantityMap>();
        }
    
        public int Id { get; set; }
        public string Product_No { get; set; }
        public string Product_Name { get; set; }
        public string Product_Details { get; set; }
        public Nullable<int> Gender_Id { get; set; }
        public Nullable<int> Country_Id { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<bool> Is_Delete { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_On { get; set; }
        public string Image_Path { get; set; }
    
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductQuantityMap> ProductQuantityMaps { get; set; }
        public virtual Country Country { get; set; }
    }
}
