﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopBridgeEntities2 : DbContext
    {
        public ShopBridgeEntities2()
            : base("name=ShopBridgeEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ItemMaster> ItemMasters { get; set; }
        public virtual DbSet<ManageMasterStock> ManageMasterStocks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
