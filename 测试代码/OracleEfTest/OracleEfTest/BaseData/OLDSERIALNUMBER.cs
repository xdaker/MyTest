namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.OLDSERIALNUMBER")]
    public partial class OLDSERIALNUMBER
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal PRODUCTSYSNO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(512)]
        public string SN { get; set; }
    }
}
