﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyekpad
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_toko_alat_musikEntities : DbContext
    {
        public db_toko_alat_musikEntities()
            : base("name=db_toko_alat_musikEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alatmusik> alatmusiks { get; set; }
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<color> colors { get; set; }
        public virtual DbSet<discount> discounts { get; set; }
        public virtual DbSet<dtrans_beli> dtrans_beli { get; set; }
        public virtual DbSet<dtrans_service> dtrans_service { get; set; }
        public virtual DbSet<htrans_beli> htrans_beli { get; set; }
        public virtual DbSet<htrans_service> htrans_service { get; set; }
        public virtual DbSet<instrument> instruments { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<service_category> service_category { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<variant> variants { get; set; }
    }
}
