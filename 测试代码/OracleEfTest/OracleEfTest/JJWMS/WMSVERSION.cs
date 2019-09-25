namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WMSVERSION")]
    public partial class WMSVERSION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string VERSIONCODE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ISENABLE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }
    }
}
