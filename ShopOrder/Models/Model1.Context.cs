﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopOrder.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopOrderEntities : DbContext
    {
        public ShopOrderEntities()
            : base("name=ShopOrderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DANH> DANHs { get; set; }
        public virtual DbSet<DDANG> DDANGs { get; set; }
        public virtual DbSet<DMATHANG> DMATHANGs { get; set; }
        public virtual DbSet<DMAU> DMAUs { get; set; }
        public virtual DbSet<DMAUCHITIET> DMAUCHITIETs { get; set; }
        public virtual DbSet<DNHOMHANG> DNHOMHANGs { get; set; }
        public virtual DbSet<DPHANLOAI> DPHANLOAIs { get; set; }
        public virtual DbSet<DSIZE> DSIZEs { get; set; }
        public virtual DbSet<DSIZECHITIET> DSIZECHITIETs { get; set; }
        public virtual DbSet<DTHOIGIANDAT> DTHOIGIANDATs { get; set; }
    }
}
