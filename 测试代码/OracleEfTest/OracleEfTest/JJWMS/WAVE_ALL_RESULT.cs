namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WAVE_ALL_RESULT")]
    public partial class WAVE_ALL_RESULT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SYSNO { get; set; }

        [StringLength(100)]
        public string EXTERNORDERID { get; set; }

        [StringLength(100)]
        public string ORDERNUM { get; set; }

        public long? ORDERSYSNO { get; set; }

        [StringLength(100)]
        public string WAVENUM { get; set; }

        public long? WAVESYSNO { get; set; }

        public long? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(200)]
        public string SKUNAME { get; set; }

        [StringLength(200)]
        public string SKUCLASS { get; set; }

        [StringLength(4000)]
        public string REASON { get; set; }

        public decimal? ORDERQTY { get; set; }

        public long? ORDERLINESYSNO { get; set; }
    }
}
