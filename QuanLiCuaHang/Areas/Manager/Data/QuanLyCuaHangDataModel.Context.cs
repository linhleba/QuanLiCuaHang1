﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiCuaHang.Areas.Manager.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYCUAHANGEntity : DbContext
    {
        public QUANLYCUAHANGEntity()
            : base("name=QUANLYCUAHANGEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BCTONKHO> BCTONKHOes { get; set; }
        public virtual DbSet<CHITIET_PHIEUDV> CHITIET_PHIEUDV { get; set; }
        public virtual DbSet<CHITIET_PMH> CHITIET_PMH { get; set; }
        public virtual DbSet<CT_PHIEUBANHANG> CT_PHIEUBANHANG { get; set; }
        public virtual DbSet<DONVITINH> DONVITINHs { get; set; }
        public virtual DbSet<LOAIDV> LOAIDVs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<PHIEUBANHANG> PHIEUBANHANGs { get; set; }
        public virtual DbSet<PHIEUDV> PHIEUDVs { get; set; }
        public virtual DbSet<PHIEUMUAHANG> PHIEUMUAHANGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TINHTRANGDV> TINHTRANGDVs { get; set; }
        public virtual DbSet<TINHTRANGPDV> TINHTRANGPDVs { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }
    }
}