using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementV1.Models.ViewModels
{
    public class VMProduct: Product
    {
        public int Color_Id { get; set; }
        public float Quantity { get; set; }
        public int Material_Id { get; set; }
        public int Category_Id { get; set; }
        public int Size_Group_Id { get; set; }
        public double Price { get; set; }
    }
}