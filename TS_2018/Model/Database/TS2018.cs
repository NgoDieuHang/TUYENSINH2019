namespace TS_2018.Model.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TS2018 : DbContext
    {
        public TS2018()
            : base("name=TS2018")
        {
        }

        public virtual DbSet<BHYT> BHYT { get; set; }
        public virtual DbSet<BIENLAI> BIENLAI { get; set; }
        public virtual DbSet<CHUONGTRINH> CHUONGTRINH { get; set; }
        public virtual DbSet<NGANHHOC> NGANHHOC { get; set; }
        public virtual DbSet<PHIEUNHAPHOC> PHIEUNHAPHOC { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USER> USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BHYT>()
                .HasMany(e => e.BIENLAI)
                .WithRequired(e => e.BHYT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TienBHYT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TienHocPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TienGDQP)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TienAVDV)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TienBHTT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TienKhamSK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BIENLAI>()
                .HasOptional(e => e.SINHVIEN)
                .WithRequired(e => e.BIENLAI);

            modelBuilder.Entity<CHUONGTRINH>()
                .HasMany(e => e.BIENLAI)
                .WithRequired(e => e.CHUONGTRINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGANHHOC>()
                .HasMany(e => e.SINHVIEN)
                .WithRequired(e => e.NGANHHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAPHOC>()
                .HasOptional(e => e.SINHVIEN)
                .WithRequired(e => e.PHIEUNHAPHOC);
        }
    }
}
