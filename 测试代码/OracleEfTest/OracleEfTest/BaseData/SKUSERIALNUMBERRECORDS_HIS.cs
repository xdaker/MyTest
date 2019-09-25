namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SKUSERIALNUMBERRECORDS_HIS")]
    public partial class SKUSERIALNUMBERRECORDS_HIS
    {
        [Key]
        [StringLength(100)]
        public string WQFREENO { get; set; }

        [StringLength(128)]
        public string SERIALNUMBER { get; set; }

        public DateTime? SNCOLLECTDATE { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        public decimal? RECEIPTSYSNO { get; set; }

        [StringLength(32)]
        public string RECEIPTNUM { get; set; }

        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        [StringLength(64)]
        public string LC_CODE { get; set; }

        public DateTime? LOTNUMBERCOLLECTDATE { get; set; }

        public decimal? ORDERLINESYSNO { get; set; }

        public DateTime? ORDERCOLLECTDATE { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string ROWCREATEUSERID { get; set; }

        [StringLength(64)]
        public string ROWCREATEUSERNAME { get; set; }

        [StringLength(32)]
        public string BINDSNUSERID { get; set; }

        [StringLength(64)]
        public string BINDSNUSERNAME { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        public decimal? ORDERSYSNO { get; set; }

        [StringLength(100)]
        public string TEL { get; set; }
    }
}
