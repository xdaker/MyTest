namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.TYPETABLE")]
    public partial class TYPETABLE
    {
        [Key]
        [StringLength(1024)]
        public string SYSNO { get; set; }

        [StringLength(1024)]
        public string NAME { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? SUBORDINATETYPE { get; set; }
    }
}
