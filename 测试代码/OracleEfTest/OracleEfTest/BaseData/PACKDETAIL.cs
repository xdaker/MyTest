namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.PACKDETAIL")]
    public partial class PACKDETAIL
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string PACKCODE { get; set; }

        [StringLength(128)]
        public string PACKDESC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(32)]
        public string PACKLINENUM { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal BASEUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string UMCODE { get; set; }

        [StringLength(64)]
        public string UMCODEDESC { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal QTY { get; set; }

        [StringLength(32)]
        public string BARCODE { get; set; }

        public decimal? LENGTH { get; set; }

        public decimal? WIDTH { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? CUBE { get; set; }

        public decimal? WEIGHT { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ENABLEFLAG { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime ROWMODIFYDATE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
