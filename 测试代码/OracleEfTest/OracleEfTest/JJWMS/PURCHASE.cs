namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PURCHASE")]
    public partial class PURCHASE
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(50)]
        public string SRCNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string SRCTTYPE { get; set; }

        [Required]
        [StringLength(100)]
        public string VENDORCODE { get; set; }

        [Required]
        [StringLength(200)]
        public string VENDORNAME { get; set; }

        [StringLength(200)]
        public string VENDORADDRESS { get; set; }

        [StringLength(200)]
        public string VENDORCONTACT { get; set; }

        [StringLength(100)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(200)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(200)]
        public string WAREHOUSECONTRACT { get; set; }

        [StringLength(200)]
        public string WAREHOUSEPHONE { get; set; }

        [StringLength(50)]
        public string COMPANYSYSNO { get; set; }

        [StringLength(100)]
        public string COMPANYCODE { get; set; }

        [StringLength(200)]
        public string COMPANYNAME { get; set; }

        [StringLength(300)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string PURCHASER { get; set; }

        [StringLength(50)]
        public string SHIPPINGTYPE { get; set; }

        public decimal SRCSTATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string SRCDATE { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(100)]
        public string CONTRACT { get; set; }

        [StringLength(320)]
        public string REMARKS { get; set; }

        public DateTime? CLOSEDDATE { get; set; }

        [StringLength(32)]
        public string CLOSEDUSERID { get; set; }

        [StringLength(64)]
        public string CLOSEDUSERNAME { get; set; }

        [StringLength(100)]
        public string FILE1 { get; set; }

        [StringLength(100)]
        public string FILE2 { get; set; }

        [StringLength(100)]
        public string FILE3 { get; set; }

        [StringLength(100)]
        public string FILE4 { get; set; }

        [StringLength(100)]
        public string FILE5 { get; set; }

        [StringLength(100)]
        public string FILE6 { get; set; }

        [StringLength(100)]
        public string FILE7 { get; set; }

        [StringLength(100)]
        public string FILE8 { get; set; }

        [StringLength(100)]
        public string FILE9 { get; set; }

        [StringLength(100)]
        public string FILE10 { get; set; }
    }
}
