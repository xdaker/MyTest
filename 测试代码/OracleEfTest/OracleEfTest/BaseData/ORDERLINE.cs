namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.ORDERLINE")]
    public partial class ORDERLINE
    {
        [Key]
        public decimal SYSNO { get; set; }

        public int? ORDERSYSNO { get; set; }

        [StringLength(32)]
        public string ORDERLINENUM { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [StringLength(32)]
        public string EXTERNORDERLINENUM { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUDESC { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public decimal ORDERLINESTATUS { get; set; }

        public decimal QTYORDERED { get; set; }

        public decimal QTYALLOCATED { get; set; }

        public decimal QTYPICKED { get; set; }

        public decimal QTYSHIPPED { get; set; }

        public decimal PRICE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal WEIGHT { get; set; }

        [StringLength(32)]
        public string LOT { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal? ORDERLINETYPE { get; set; }

        public decimal? WORKISOVER { get; set; }

        public decimal QTYCHANGE { get; set; }

        [StringLength(4)]
        public string CARDTYPE { get; set; }

        [StringLength(100)]
        public string PRODUCTTYPE { get; set; }

        [StringLength(20)]
        public string PACKTYPE { get; set; }

        [StringLength(100)]
        public string CARDNUMBER { get; set; }

        [StringLength(20)]
        public string PROCESSINGTYPE { get; set; }

        [StringLength(200)]
        public string PROCESSINGCONTENT { get; set; }

        [StringLength(32)]
        public string PACKAGEID { get; set; }

        [StringLength(32)]
        public string DETAILID { get; set; }

        [StringLength(32)]
        public string IS_CARD_USER { get; set; }

        [StringLength(32)]
        public string IS_AUDIT_ECCARD { get; set; }

        public decimal? POSTSAP { get; set; }

        public decimal? VALVE { get; set; }
    }
}
