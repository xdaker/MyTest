namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PACK")]
    public partial class PACK
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        public string DESCRIPTION { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ENABLEFLAG { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime ROWMODIFYDATE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
