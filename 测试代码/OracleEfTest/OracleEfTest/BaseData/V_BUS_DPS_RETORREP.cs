namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_BUS_DPS_RETORREP")]
    public partial class V_BUS_DPS_RETORREP
    {
        [StringLength(16)]
        public string PARALLELISM_ST { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string CODE { get; set; }

        public decimal? POS1 { get; set; }

        public decimal? POS2 { get; set; }

        [StringLength(64)]
        public string LPN1 { get; set; }

        [StringLength(64)]
        public string LPN2 { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        public decimal? QTYONHAND1 { get; set; }

        public decimal? QTYONHAND2 { get; set; }

        [StringLength(64)]
        public string LOTNUMBER1 { get; set; }

        [StringLength(64)]
        public string LOTNUMBER2 { get; set; }
    }
}
