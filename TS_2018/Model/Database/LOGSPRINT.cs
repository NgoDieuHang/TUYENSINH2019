namespace TS_2018.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("LOGSPRINT")]

    public class LOGSPRINT
    {
        [Key]
        public int ID { get; set; }
        public string SBD { get; set; }
        public int  IdUserPrint { get; set; }
        public DateTime DatePrint { get; set; }
    }
}
