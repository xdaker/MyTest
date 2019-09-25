namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.ORDERSRECORD")]
    public partial class ORDERSRECORD
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        public decimal? ORDERSYSNO { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        public decimal? ORDERLINESYSNO { get; set; }

        public decimal? LOCATIONSYSNO { get; set; }

        [StringLength(100)]
        public string LOCATIONCODE { get; set; }

        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        [StringLength(50)]
        public string INVUNIT { get; set; }

        public decimal? ORDERSINVNUM { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        public decimal? QTY { get; set; }

        public decimal? AVERAGE { get; set; }

        [StringLength(50)]
        public string VENDORCODE { get; set; }

        [StringLength(128)]
        public string VENDORNAME { get; set; }

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

        [StringLength(320)]
        public string REMARKS { get; set; }
    }
}
