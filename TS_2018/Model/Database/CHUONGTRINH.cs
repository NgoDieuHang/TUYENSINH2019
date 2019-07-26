namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUONGTRINH")]
    public partial class CHUONGTRINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUONGTRINH()
        {
            BIENLAI = new HashSet<BIENLAI>();
            SINHVIEN = new HashSet<SINHVIEN>();
        }

        [Key]
        public int ID_CT { get; set; }

        [Required]
        public string Ten_CT { get; set; }

        public decimal SoTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAI { get; set; }
        public virtual ICollection<SINHVIEN> SINHVIEN { get; set; }

    }
}
