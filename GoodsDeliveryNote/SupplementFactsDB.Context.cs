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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DevConn : DbContext
    {
        public DevConn()
            : base("name=DevConn")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<IncludeImportedProduct> IncludeImportedProducts { get; set; }
        public virtual DbSet<IncludeOrderProduct> IncludeOrderProducts { get; set; }
        public virtual DbSet<OrderReceipt> OrderReceipts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<WarehouseReceipt> WarehouseReceipts { get; set; }
    }
}
