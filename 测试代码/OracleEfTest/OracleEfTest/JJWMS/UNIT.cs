namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.UNIT")]
    public partial class UNIT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string SYSNO { get; set; }

        [StringLength(32)]
        public string UNITCODE { get; set; }

        [StringLength(64)]
        public string UNITNAME { get; set; }

        public int? UNITLEVEL { get; set; }

        public int? EXPRESSION { get; set; }

        [StringLength(32)]
        public string TYPEST { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }
    }
}
