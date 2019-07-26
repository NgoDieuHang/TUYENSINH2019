namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BHYT")]
    public partial class BHYT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BHYT()
        {
            BIENLAI = new HashSet<BIENLAI>();
        }

        [Key]
        public int ID_BHYT { get; set; }

        [Required]
        public string Loai_BHYT { get; set; }

        public double LoaiTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAI { get; set; }
    }
}
