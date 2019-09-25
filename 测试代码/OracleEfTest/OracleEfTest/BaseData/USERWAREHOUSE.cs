namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.USERWAREHOUSE")]
    public partial class USERWAREHOUSE
    {
        [Key]
        [Column(Order = 0)]
        public decimal USERSYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public string USERAUTHNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal WAREHOUSESYSNO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

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

        [StringLength(3000)]
        public string USERNAME { get; set; }
    }
}
