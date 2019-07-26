namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(500)]
        public string HoTenCanBo { get; set; }
    }
}
