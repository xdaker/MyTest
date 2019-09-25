namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.ACTIVITYLOG")]
    public partial class ACTIVITYLOG
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal WAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal WORKTYPE { get; set; }

        public decimal? WAVESYSNO { get; set; }

        [StringLength(32)]
        public string WAVENUM { get; set; }

        public decimal? RECEIPTSYSNO { get; set; }

        [StringLength(32)]
        public string RECEIPTNUM { get; set; }

        public decimal? ORDERSYSNO { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        public decimal LOCATIONQTY { get; set; }

        public decimal SKUITEMQTY { get; set; }

        public decimal SKUTOTALQTY { get; set; }

        [StringLength(32)]
        public string OPERATORUSERID1 { get; set; }

        [StringLength(64)]
        public string OPERATORUSERNAME1 { get; set; }

        [StringLength(32)]
        public string OPERATORUSERID2 { get; set; }

        [StringLength(64)]
        public string OPERATORUSERNAME2 { get; set; }

        [StringLength(32)]
        public string OPERATORUSERID3 { get; set; }

        [StringLength(64)]
        public string OPERATORUSERNAME3 { get; set; }

        [StringLength(32)]
        public string OPERATORUSERID4 { get; set; }

        [StringLength(64)]
        public string OPERATORUSERNAME4 { get; set; }

        public DateTime? EXPSTARTTIME { get; set; }

        public DateTime? EXPENDTIME { get; set; }

        public decimal? EXPELAPSEDTIME { get; set; }

        public DateTime? STARTTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        public decimal? ELAPSEDTIME { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        [StringLength(32)]
        public string SOURCEID { get; set; }
    }
}
