﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Oracle : DbContext
    {
        public Oracle()
            : base("name=Oracle")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CT_NHAPHANG> CT_NHAPHANG { get; set; }
        public DbSet<CHUCVU> CHUCVUs { get; set; }
        public DbSet<HANGHOA> HANGHOAs { get; set; }
        public DbSet<LOAIHANGHOA> LOAIHANGHOAs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<NHAPHANPHOI> NHAPHANPHOIs { get; set; }
        public DbSet<NHASANXUAT> NHASANXUATs { get; set; }
        public DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }
        public DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public DbSet<CT_PHIEUXUAT> CT_PHIEUXUAT { get; set; }
        public DbSet<VIEWCHUCVU> VIEWCHUCVUs { get; set; }
        public DbSet<VIEWHANGHOA> VIEWHANGHOAs { get; set; }
        public DbSet<VIEWLOAIHANG> VIEWLOAIHANGs { get; set; }
        public DbSet<VIEWNHASANXUAT> VIEWNHASANXUATs { get; set; }
    
        public virtual int SUACHUCVU(Nullable<decimal> p_MACHUCVU, string p_TENCHUCVU, string p_MOTA)
        {
            var p_MACHUCVUParameter = p_MACHUCVU.HasValue ?
                new ObjectParameter("P_MACHUCVU", p_MACHUCVU) :
                new ObjectParameter("P_MACHUCVU", typeof(decimal));
    
            var p_TENCHUCVUParameter = p_TENCHUCVU != null ?
                new ObjectParameter("P_TENCHUCVU", p_TENCHUCVU) :
                new ObjectParameter("P_TENCHUCVU", typeof(string));
    
            var p_MOTAParameter = p_MOTA != null ?
                new ObjectParameter("P_MOTA", p_MOTA) :
                new ObjectParameter("P_MOTA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUACHUCVU", p_MACHUCVUParameter, p_TENCHUCVUParameter, p_MOTAParameter);
        }
    
        public virtual int THEMCHUCVU(Nullable<decimal> p_MACHUCVU, string p_TENCHUCVU, string p_MOTA)
        {
            var p_MACHUCVUParameter = p_MACHUCVU.HasValue ?
                new ObjectParameter("P_MACHUCVU", p_MACHUCVU) :
                new ObjectParameter("P_MACHUCVU", typeof(decimal));
    
            var p_TENCHUCVUParameter = p_TENCHUCVU != null ?
                new ObjectParameter("P_TENCHUCVU", p_TENCHUCVU) :
                new ObjectParameter("P_TENCHUCVU", typeof(string));
    
            var p_MOTAParameter = p_MOTA != null ?
                new ObjectParameter("P_MOTA", p_MOTA) :
                new ObjectParameter("P_MOTA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMCHUCVU", p_MACHUCVUParameter, p_TENCHUCVUParameter, p_MOTAParameter);
        }
    }
}
