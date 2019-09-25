namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.INVENTORY")]
    public partial class INVENTORY
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal COMPANYSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public decimal WAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal SKUSYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(300)]
        public string SKUDESC { get; set; }

        public decimal LOCATIONSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        [Required]
        [StringLength(64)]
        public string LOTNUMBER { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        public decimal QTYONHAND { get; set; }

        public decimal ISHOLD { get; set; }

        public decimal INVSTATUS { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal DISQTY { get; set; }

        [StringLength(64)]
        public string COMMENTS { get; set; }

        public decimal? QTYPICK { get; set; }

        public decimal? NETWEIGHT { get; set; }

        public decimal? GROSSWEIGHT { get; set; }

        public decimal? INVNUM { get; set; }

        public decimal? AVERAGEWEIGHT { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [StringLength(50)]
        public string UNITCODE { get; set; }

        [StringLength(50)]
        public string INVUNIT { get; set; }

        [StringLength(50)]
        public string INVUNITCODE { get; set; }

        public decimal? VENDORSYSNO { get; set; }

        [StringLength(50)]
        public string VENDORCODE { get; set; }

        [StringLength(128)]
        public string VENDORNAME { get; set; }

        public decimal? DISCHARGE { get; set; }
    }
}
