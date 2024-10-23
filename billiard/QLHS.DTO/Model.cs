using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bida.DTO
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<BAN> BAN { get; set; }
        public virtual DbSet<BIENLAI> BIENLAI { get; set; }
        public virtual DbSet<CHITIETBIENLAI> CHITIETBIENLAI { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<QUANLI> QUANLI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAN>()
                .HasMany(e => e.BIENLAI)
                .WithRequired(e => e.BAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.MANHANVIEN)
                .IsUnicode(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TONGTIEN)
                .IsFixedLength();

            modelBuilder.Entity<CHITIETBIENLAI>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETBIENLAI>()
                .Property(e => e.MABIENLAI)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETBIENLAI>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANHANVIEN)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.PASSNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BIENLAI)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.QUANLI)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<QUANLI>()
                .Property(e => e.MANHANVIEN)
                .IsUnicode(false);

            modelBuilder.Entity<QUANLI>()
                .Property(e => e.TENNHANVIEN)
                .IsUnicode(false);

            modelBuilder.Entity<QUANLI>()
                .Property(e => e.PASSNV)
                .IsUnicode(false);
        }
    }
}
