﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTUDQL2_QUAN_LY_CCVIDEO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyCCVEntities : DbContext
    {
        public QuanLyCCVEntities()
            : base("name=QuanLyCCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CapDoTaiKhoan> CapDoTaiKhoans { get; set; }
        public virtual DbSet<LoaiVideo> LoaiVideos { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<The> Thes { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<YeuThich_XemGanDay> YeuThich_XemGanDay { get; set; }
    }
}