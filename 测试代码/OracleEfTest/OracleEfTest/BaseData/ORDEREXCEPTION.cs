namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.ORDEREXCEPTION")]
    public partial class ORDEREXCEPTION
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(50)]
        public string EXCEPTIONNUM { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? GENTYPE { get; set; }

        [StringLength(50)]
        public string ORDERNUM { get; set; }

        public decimal? ORDERSYSNO { get; set; }

        public decimal? DEPT { get; set; }

        public decimal? REASON { get; set; }

        public DateTime? CANCELDATE { get; set; }

        [StringLength(32)]
        public string CANCELUSERID { get; set; }

        [StringLength(64)]
        public string CANCELUSERNAME { get; set; }

        public DateTime? CONFIRMDATE { get; set; }

        [StringLength(32)]
        public string CONFIRMUSERID { get; set; }

        [StringLength(64)]
        public string CONFIRMUSERNAME { get; set; }

        public DateTime? DEALDATE { get; set; }

        [StringLength(32)]
        public string DEALUSERID { get; set; }

        [StringLength(64)]
        public string DEALUSERNAME { get; set; }

        [StringLength(500)]
        public string COMMENTS { get; set; }

        public decimal? ENABLEFLAG { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(50)]
        public string WAVENUM { get; set; }

        public decimal? WAVESYSNO { get; set; }

        [StringLength(50)]
        public string EXCEPTIOTYPE { get; set; }

        [StringLength(50)]
        public string EXTERNORDERID { get; set; }

        [StringLength(64)]
        public string ERRTYPE { get; set; }
    }
}
