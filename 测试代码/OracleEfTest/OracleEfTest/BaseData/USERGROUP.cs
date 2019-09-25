namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.USERGROUP")]
    public partial class USERGROUP
    {
        [Key]
        [Column(Order = 0)]
        public decimal GROUPSYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public string GROUPNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal USERSYSNO { get; set; }

        [Key]
        [Column(Order = 3)]
        public string USERAUTHNAME { get; set; }

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
    }
}
