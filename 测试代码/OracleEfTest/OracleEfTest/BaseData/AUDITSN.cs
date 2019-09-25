namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.AUDITSN")]
    public partial class AUDITSN
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(128)]
        public string SERIALNUMBER { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        [StringLength(64)]
        public string LC_CODE { get; set; }

        public decimal? ORDERLINESYSNO { get; set; }

        public DateTime? ORDERCOLLECTDATE { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string ROWCREATEUSERID { get; set; }

        [StringLength(64)]
        public string ROWCREATEUSERNAME { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        public decimal? ORDERSYSNO { get; set; }

        [StringLength(128)]
        public string EXTERNORDERID { get; set; }

        [StringLength(128)]
        public string ORDERNUM { get; set; }

        [StringLength(128)]
        public string WAVENUM { get; set; }
    }
}
