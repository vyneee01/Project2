﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quản_Lý_Sách.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class K22CNT2NguyenNgocVy2210900086Entities : DbContext
    {
        public K22CNT2NguyenNgocVy2210900086Entities()
            : base("name=K22CNT2NguyenNgocVy2210900086Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GIAO_DICH> GIAO_DICH { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<QUAN_TRI> QUAN_TRI { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<THE_LOAI> THE_LOAI { get; set; }
    }
}
