namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.INVENTORYCHANGEPLAN")]
    public partial class INVENTORYCHANGEPLAN
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal TRANTYPE { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(32)]
        public string FROMLOCCODE { get; set; }

        [StringLength(32)]
        public string TOLOCCODE { get; set; }

        [StringLength(64)]
        public string FROMLPN { get; set; }

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
    }
}
