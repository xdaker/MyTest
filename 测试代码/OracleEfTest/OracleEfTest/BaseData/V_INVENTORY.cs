namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_INVENTORY")]
    public partial class V_INVENTORY
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public string COMPANYNAME { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string SKUDESC { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal LOCATIONSYSNO { get; set; }

        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string LOTNUMBER { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal QTYONHAND { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ISHOLD { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal INVSTATUS { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal WAREHOUSESYSNO { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal COMPANYSYSNO { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [StringLength(50)]
        public string QRCODE { get; set; }

        public decimal? VALVE { get; set; }

        [StringLength(64)]
        public string UNCODE { get; set; }
    }
}
