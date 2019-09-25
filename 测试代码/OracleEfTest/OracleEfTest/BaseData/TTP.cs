namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.TTP")]
    public partial class TTP
    {
        [Key]
        [StringLength(64)]
        public string CODE { get; set; }

        [StringLength(64)]
        public string ALSLE { get; set; }

        [StringLength(16)]
        public string LEVELNO { get; set; }

        [StringLength(16)]
        public string BAY { get; set; }

        [StringLength(16)]
        public string DEEP { get; set; }

        public decimal? INVENTORYSTS { get; set; }

        public decimal? LOCATIONSTS { get; set; }
    }
}
