namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_SUPPLIES")]
    public partial class BASE_SUPPLIES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SUPPLIERID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FULLNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TELEPHONE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string FAX { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string ACCOUNTSMETHOD { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string LINKMAN { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string LEADINGOFFICIALID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string ADDRESS { get; set; }
    }
}
