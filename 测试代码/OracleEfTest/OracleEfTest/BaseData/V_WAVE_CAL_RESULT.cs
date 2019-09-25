namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_WAVE_CAL_RESULT")]
    public partial class V_WAVE_CAL_RESULT
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        public int? ORDERSYSNO { get; set; }

        [StringLength(32)]
        public string ORDERLINENUM { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [StringLength(32)]
        public string EXTERNORDERID { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUDESC { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal QTYORDERED { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal QTYSHORT { get; set; }

        [StringLength(32)]
        public string LOT { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime ROWMODIFYDATE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(64)]
        public string REASON { get; set; }

        public int? ORDERDTLSYSNO { get; set; }

        public int? ORDEREXCEPTIONSYSNO { get; set; }

        [StringLength(64)]
        public string ERRTYPE { get; set; }

        [StringLength(1000)]
        public string REASONDESC { get; set; }

        [StringLength(50)]
        public string WAVENUM { get; set; }

        public decimal? WAVESYSNO { get; set; }

        [StringLength(50)]
        public string EXCEPTIOTYPE { get; set; }
    }
}
