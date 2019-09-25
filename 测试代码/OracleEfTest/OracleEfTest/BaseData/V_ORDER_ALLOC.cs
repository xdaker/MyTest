namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_ORDER_ALLOC")]
    public partial class V_ORDER_ALLOC
    {
        [Key]
        [Column(Order = 0)]
        public decimal ORDERLINESYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUDESC { get; set; }

        public decimal? SKUSYSNO { get; set; }

        public decimal? ORDERLINETYPE { get; set; }

        [StringLength(100)]
        public string CARDNUMBER { get; set; }

        [StringLength(4)]
        public string CARDTYPE { get; set; }

        public decimal? ORDERTYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal QTYORDERED { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal QTYALLOCATED { get; set; }

        [StringLength(32)]
        public string ORDERLINENUM { get; set; }

        public int? ORDERSYSNO { get; set; }

        public decimal? WAVESYSNO { get; set; }

        [StringLength(32)]
        public string WAVENUM { get; set; }

        [StringLength(64)]
        public string EXTERNORDERID { get; set; }

        public decimal? WAREHOUSESYSNO { get; set; }

        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal? COMPANYSYSNO { get; set; }

        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        public decimal? SOUECEID { get; set; }

        [StringLength(32)]
        public string SOUECENUM { get; set; }

        public decimal? NEEDQTY { get; set; }

        public decimal? VALVE { get; set; }
    }
}
