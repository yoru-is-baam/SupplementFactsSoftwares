//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoodsDeliveryNote
{
    using System;
    using System.Collections.Generic;
    
    public partial class IncludeOrderProduct
    {
        public int TotalProductQuantity { get; set; }
        public int TotalProductPrice { get; set; }
        public int OrderID { get; set; }
        public string ProductID { get; set; }
    
        public virtual OrderReceipt OrderReceipt { get; set; }
        public virtual Product Product { get; set; }
    }
}
