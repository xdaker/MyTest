namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.INVENTORYCHANGEPLANHISTORY")]
    public partial class INVENTORYCHANGEPLANHISTORY
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal TRANTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(32)]
        public string FROMLOCCODE { get; set; }

        [StringLength(32)]
        public string TOLOCCODE { get; set; }

        [StringLength(64)]
        public string FROMLPN { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ISWHOLEPLATE { get; set; }

        [StringLength(64)]
        public string TOLPN { get; set; }

        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        [StringLength(64)]
        public string TEMPLPN { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal? QTYINTRANSIT { get; set; }

        public decimal? INVNUM { get; set; }

        public decimal? AVERAGE { get; set; }

        public decimal? ALREADYNUM { get; set; }
    }
}
