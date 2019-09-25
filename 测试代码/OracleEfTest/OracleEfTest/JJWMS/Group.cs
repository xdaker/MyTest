namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.Group")]
    public partial class Group
    {
        [Key]
        [Column(Order = 0)]
        public decimal SysNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string Comments { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal EnableFlag { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime RowCreateDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(32)]
        public string CreateUserID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(64)]
        public string CreateUserName { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime RowModifyDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(32)]
        public string ModifyUserID { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string ModifyUserName { get; set; }
    }
}
