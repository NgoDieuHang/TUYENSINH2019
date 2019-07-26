namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGANHHOC")]
    public partial class NGANHHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGANHHOC()
        {
            SINHVIEN = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(50)]
        public string ID_Nganh { get; set; }

        [Required]
        public string Ten_Nganh { get; set; }

        public int IDUserTuyenSinh { get; set; }

        public DateTime NgayTuyenSinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIEN { get; set; }
    }
}