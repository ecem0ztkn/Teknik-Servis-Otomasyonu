//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnicalServices
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbTeknikServisEntities : DbContext
    {
        public DbTeknikServisEntities()
            : base("name=DbTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_ArizaDetay> tbl_ArizaDetay { get; set; }
        public virtual DbSet<tbl_Cari> tbl_Cari { get; set; }
        public virtual DbSet<tbl_Departman> tbl_Departman { get; set; }
        public virtual DbSet<tbl_FaturaBilgi> tbl_FaturaBilgi { get; set; }
        public virtual DbSet<tbl_FaturaDetay> tbl_FaturaDetay { get; set; }
        public virtual DbSet<tbl_Gider> tbl_Gider { get; set; }
        public virtual DbSet<tbl_Kategori> tbl_Kategori { get; set; }
        public virtual DbSet<tbl_Notlar> tbl_Notlar { get; set; }
        public virtual DbSet<tbl_Personel> tbl_Personel { get; set; }
        public virtual DbSet<tbl_Urun> tbl_Urun { get; set; }
        public virtual DbSet<tbl_UrunHareket> tbl_UrunHareket { get; set; }
        public virtual DbSet<tbl_UrunKabul> tbl_UrunKabul { get; set; }
        public virtual DbSet<tbl_UrunTakip> tbl_UrunTakip { get; set; }
        public virtual DbSet<tbl_Hakkimizda> tbl_Hakkimizda { get; set; }
        public virtual DbSet<tbl_Iletisim> tbl_Iletisim { get; set; }
    }
}
