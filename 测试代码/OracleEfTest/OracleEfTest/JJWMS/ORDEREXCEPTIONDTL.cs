namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.ORDEREXCEPTIONDTL")]
    public partial class ORDEREXCEPTIONDTL
    {
        [Key]
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

        public decimal QTYORDERED { get; set; }

        public decimal QTYSHORT { get; set; }

        [StringLength(32)]
        public string LOT { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

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

        [StringLength(64)]
        public string REASON { get; set; }

        public int? ORDERDTLSYSNO { get; set; }

        public int? ORDEREXCEPTIONSYSNO { get; set; }

        [StringLength(64)]
        public string ERRTYPE { get; set; }

        [StringLength(1000)]
        public string REASONDESC { get; set; }
    }
}
