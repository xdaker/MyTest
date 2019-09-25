namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WAVEDETAIL")]
    public partial class WAVEDETAIL
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal WAVESYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string WAVENUM { get; set; }

        public decimal ORDERSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [StringLength(64)]
        public string EXTERNORDERID { get; set; }

        public decimal WAVEORDERSTATUS { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        public decimal SEQUENCE { get; set; }

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
    }
}
