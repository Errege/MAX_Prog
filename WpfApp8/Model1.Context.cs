﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp8
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WorldSkilEntities : DbContext
    {
        public WorldSkilEntities()
            : base("name=WorldSkilEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENT> AGENT { get; set; }
        public virtual DbSet<ANALYST> ANALYST { get; set; }
        public virtual DbSet<DOORS> DOORS { get; set; }
        public virtual DbSet<EMAIL> EMAIL { get; set; }
        public virtual DbSet<HISTORY> HISTORY { get; set; }
        public virtual DbSet<HISTORY_SUPPLIER> HISTORY_SUPPLIER { get; set; }
        public virtual DbSet<INDUSTRY> INDUSTRY { get; set; }
        public virtual DbSet<MANAGER> MANAGER { get; set; }
        public virtual DbSet<MASTER_INDUSTRY> MASTER_INDUSTRY { get; set; }
        public virtual DbSet<MATERIAL> MATERIAL { get; set; }
        public virtual DbSet<OFFERS> OFFERS { get; set; }
        public virtual DbSet<OPERATION> OPERATION { get; set; }
        public virtual DbSet<ORDERS> ORDERS { get; set; }
        public virtual DbSet<PHONE> PHONE { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULE { get; set; }
        public virtual DbSet<SELL_PLACE> SELL_PLACE { get; set; }
        public virtual DbSet<SHIPMENT> SHIPMENT { get; set; }
        public virtual DbSet<STANDART> STANDART { get; set; }
        public virtual DbSet<STOCKMAN> STOCKMAN { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIER { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TURNSTILE> TURNSTILE { get; set; }
        public virtual DbSet<TYPE_AGENT> TYPE_AGENT { get; set; }
        public virtual DbSet<TYPE_MATERIAL> TYPE_MATERIAL { get; set; }
        public virtual DbSet<TYPE_PRODUCT> TYPE_PRODUCT { get; set; }
        public virtual DbSet<TYPE_SUPPLIER> TYPE_SUPPLIER { get; set; }
        public virtual DbSet<UNIT_OF_MEASUREMENT> UNIT_OF_MEASUREMENT { get; set; }
    }
}
