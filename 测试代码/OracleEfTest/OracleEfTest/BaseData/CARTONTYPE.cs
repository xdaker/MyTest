namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.CARTONTYPE")]
    public partial class CARTONTYPE
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string CODE { get; set; }

        [StringLength(128)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal CUBE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal WEIGHT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal LENGTH { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal WIDTH { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal HEIGHT { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ENABLEFLAG { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime ROWMODIFYDATE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
