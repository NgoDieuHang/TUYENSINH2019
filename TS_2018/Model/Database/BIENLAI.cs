namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BIENLAI")]
    public partial class BIENLAI
    {
        [Key]
        [StringLength(8)]
        public string SBD { get; set; }

        public int ID_CT { get; set; }

        public decimal TienBHYT { get; set; }

        public decimal TienHocPhi { get; set; }

        public decimal TienGDQP { get; set; }

        public decimal TienAVDV { get; set; }

        public decimal TienBHTT { get; set; }

        public decimal TienKhamSK { get; set; }

        public decimal TongTien { get; set; }

        public int? IdUserUpdate { get; set; }

        public DateTime? NgayUpdate { get; set; }

        public int IdUserPrint { get; set; }

        public DateTime NgayPrint { get; set; }

        public virtual CHUONGTRINH CHUONGTRINH { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
