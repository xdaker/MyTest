namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.RECEIPT")]
    public partial class RECEIPT
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string RECEIPTNUM { get; set; }

        public decimal RECEIPTTYPE { get; set; }

        [StringLength(64)]
        public string SRCNUM { get; set; }

        public decimal RECEIPTSTATUS { get; set; }

        public decimal? WAREHOUSESYSNO { get; set; }

        [StringLength(128)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(32)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(128)]
        public string WAREHOUSECONTRACT { get; set; }

        [StringLength(64)]
        public string WAREHOUSEPHONE { get; set; }

        public decimal? COMPANYSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        [StringLength(512)]
        public string ADDRESS { get; set; }

        [StringLength(128)]
        public string PURCHASER { get; set; }

        public decimal? SHIPPINGTYPE { get; set; }

        public DateTime? SRCDATE { get; set; }

        public DateTime? SCHEDULEDDATE { get; set; }

        public DateTime? ARRIVEDDATE { get; set; }

        public DateTime? CLOSEDDATE { get; set; }

        [StringLength(32)]
        public string CLOSEDUSERID { get; set; }

        [StringLength(64)]
        public string CLOSEDUSERNAME { get; set; }

        public DateTime? CANCELDATE { get; set; }

        [StringLength(32)]
        public string CANCELUSERID { get; set; }

        [StringLength(64)]
        public string CANCELUSERNAME { get; set; }

        public decimal? VENDORSYSNO { get; set; }

        [StringLength(32)]
        public string VENDORCODE { get; set; }

        [StringLength(128)]
        public string VENDORNAME { get; set; }

        [StringLength(128)]
        public string VENDORADDRESS { get; set; }

        [StringLength(128)]
        public string VENDORRETURNADDRESS { get; set; }

        [StringLength(64)]
        public string VENDORCONTACT { get; set; }

        [StringLength(64)]
        public string VENDORPHONE { get; set; }

        [StringLength(64)]
        public string VENDORFAX { get; set; }

        [StringLength(64)]
        public string SALESMAN { get; set; }

        public decimal? PRIORITY { get; set; }

        public decimal? CARRIERSYSNO { get; set; }

        [StringLength(32)]
        public string CARRIERCODE { get; set; }

        [StringLength(128)]
        public string CARRIERNAME { get; set; }

        [StringLength(64)]
        public string SONUMBER { get; set; }

        [StringLength(64)]
        public string HOSTNUMBER { get; set; }

        [StringLength(64)]
        public string TRAILERID { get; set; }

        [StringLength(256)]
        public string COMMENTIN { get; set; }

        [StringLength(256)]
        public string COMMENTOUT { get; set; }

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

        public decimal? NUM_NO { get; set; }

        public decimal? SRCSYSTEM { get; set; }

        [StringLength(16)]
        public string TICKETNAME { get; set; }

        [StringLength(64)]
        public string SRCNUM2 { get; set; }

        public decimal? ISCROSSWAREHOUSE { get; set; }

        public decimal? ISFACTORYSEND { get; set; }

        public DateTime? AUDITDATE { get; set; }

        [StringLength(64)]
        public string AUDITOR { get; set; }

        [StringLength(150)]
        public string WORKSHOP { get; set; }

        [StringLength(150)]
        public string PRODUCTIONLINE { get; set; }

        [StringLength(100)]
        public string APPLICANT { get; set; }

        [StringLength(150)]
        public string WORKSHOPCODE { get; set; }

        [StringLength(150)]
        public string PRODUCTIONLINECODE { get; set; }

        [StringLength(150)]
        public string SHIPPINGDEPARTMENT { get; set; }

        [StringLength(150)]
        public string RECEIVINGDEPARTMENT { get; set; }

        [StringLength(150)]
        public string RECEIVINGER { get; set; }
    }
}
