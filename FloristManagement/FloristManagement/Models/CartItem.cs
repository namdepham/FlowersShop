//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FloristManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartItem
    {
        public int CartItemID { get; set; }
        public int BouquetID { get; set; }
        public int CartID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Bouquet Bouquet { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
