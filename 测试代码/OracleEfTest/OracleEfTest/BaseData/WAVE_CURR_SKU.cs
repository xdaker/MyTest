namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WAVE_CURR_SKU")]
    public partial class WAVE_CURR_SKU
    {
        [Key]
        public decimal SYSNO { get; set; }

        public long? WAVESYSNO { get; set; }

        [StringLength(64)]
        public string WAVENUM { get; set; }

        public long? ORDERLINESYSNO { get; set; }

        public long? ORDERSYSNO { get; set; }

        [StringLength(64)]
        public string ORDERNUM { get; set; }

        [StringLength(64)]
        public string EXTERNORDERID { get; set; }

        [StringLength(64)]
        public string SKUCODE { get; set; }

        [StringLength(64)]
        public string SKUNAME { get; set; }

        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        public decimal? QTY { get; set; }

        public DateTime ROWCREATEDATE { get; set; }
    }
}
