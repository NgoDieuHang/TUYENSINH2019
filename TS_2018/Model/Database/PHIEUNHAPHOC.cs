namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPHOC")]
    public partial class PHIEUNHAPHOC
    {
        [Key]
        [StringLength(8)]
        public string SBD { get; set; }

        public bool GT1 { get; set; }

        public bool GT2 { get; set; }

        public bool GT3 { get; set; }

        public bool GT4 { get; set; }

        public bool GT5 { get; set; }

        public bool GT6 { get; set; }

        public bool GT7 { get; set; }

        public bool GT8 { get; set; }

        public bool GT9 { get; set; }

        public bool GT10 { get; set; }

        public bool GT11 { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
