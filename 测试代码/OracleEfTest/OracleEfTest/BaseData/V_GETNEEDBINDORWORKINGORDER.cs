namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_GETNEEDBINDORWORKINGORDER")]
    public partial class V_GETNEEDBINDORWORKINGORDER
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ORDERTYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal WORKSTATUS { get; set; }

        [StringLength(128)]
        public string CUSTOMERNAME { get; set; }

        public decimal? WAVESYSNO { get; set; }

        [StringLength(32)]
        public string WAVENUM { get; set; }

        public int? ORDERSYSNO { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUDESC { get; set; }

        public decimal? QTYORDERED { get; set; }

        public decimal? QTYALLOCATED { get; set; }

        public decimal? QTYPICKED { get; set; }

        public decimal? QTYSHIPPED { get; set; }

        [StringLength(32)]
        public string LOT { get; set; }

        public decimal? ORDERLINETYPE { get; set; }

        public decimal? WORKISOVER { get; set; }

        public decimal? ISBINDDPS { get; set; }
    }
}
