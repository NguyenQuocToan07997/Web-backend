﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebStoreEntities : DbContext
    {
        public WebStoreEntities()
            : base("name=WebStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NSX> NSXes { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
