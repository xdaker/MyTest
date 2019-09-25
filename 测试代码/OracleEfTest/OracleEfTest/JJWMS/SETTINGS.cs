namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.SETTINGS")]
    public partial class SETTINGS
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [StringLength(64)]
        public string KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1000)]
        public string VALUE { get; set; }

        public decimal? PARENTID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ROWMODIFYDATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
