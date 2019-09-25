namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WQFCARTON")]
    public partial class WQFCARTON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string WQFCARTON_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal SKUSYSNO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal RECEIPTSYSNO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(32)]
        public string RECEIPTNUM { get; set; }

        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        [StringLength(64)]
        public string PACK { get; set; }

        public decimal? QTY { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(32)]
        public string ROWCREATEUSERID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(64)]
        public string ROWCREATEUSERNAME { get; set; }

        public decimal? SEQ { get; set; }

        [StringLength(100)]
        public string CUSTOMERNO { get; set; }

        [StringLength(100)]
        public string CUSTOMERNAME { get; set; }
    }
}
