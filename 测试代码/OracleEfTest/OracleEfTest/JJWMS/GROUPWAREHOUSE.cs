namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.GROUPWAREHOUSE")]
    public partial class GROUPWAREHOUSE
    {
        [Key]
        [Column(Order = 0)]
        public decimal GROUPSYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public string GROUPNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal WAREHOUSESYSNO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Key]
        [Column(Order = 4)]
        public string WAREHOUSENAME { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }
    }
}
