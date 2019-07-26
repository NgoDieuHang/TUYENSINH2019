namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [Key]
        [StringLength(8)]
        public string SBD { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_Nganh { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Lop { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string Tel { get; set; }

        [Required]
        [StringLength(20)]
        public string CMND { get; set; }

        public bool DaNopHocPhi { get; set; }

        public bool DaNhapHoc { get; set; }

        public bool DaXongNgay21 { get; set; }

        public virtual BIENLAI BIENLAI { get; set; }

        public virtual NGANHHOC NGANHHOC { get; set; }

        public virtual PHIEUNHAPHOC PHIEUNHAPHOC { get; set; }
    }
}