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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Order_Date { get; set; }
        public Nullable<int> Order_Status_Id { get; set; }
        public Nullable<int> Customer_Id { get; set; }
        public Nullable<double> Packaging_Charge { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<int> Commission_Type_Id { get; set; }
        public Nullable<double> Commission { get; set; }
        public Nullable<System.DateTime> Delivery_Date { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Updated_On { get; set; }
        public Nullable<int> Updated_By { get; set; }
    
        public virtual CommissionType CommissionType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual OrderStatu OrderStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
