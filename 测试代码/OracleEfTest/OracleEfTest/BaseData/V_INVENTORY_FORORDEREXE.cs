namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_INVENTORY_FORORDEREXE")]
    public partial class V_INVENTORY_FORORDEREXE
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

        [StringLength(16)]
        public string ALLOCZONE { get; set; }

        [StringLength(16)]
        public string PUTZONE { get; set; }

        [StringLength(16)]
        public string CCZONE { get; set; }

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
    }
}
