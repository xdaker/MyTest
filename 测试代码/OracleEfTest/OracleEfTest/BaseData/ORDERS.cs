namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.ORDERS")]
    public partial class ORDERS
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string ORDERNUM { get; set; }

        public decimal ORDERTYPE { get; set; }

        public decimal BUSINESSTYPE { get; set; }

        public decimal WORKSTATUS { get; set; }

        [Required]
        [StringLength(64)]
        public string EXTERNORDERID { get; set; }

        [StringLength(32)]
        public string EXTERNORDERTYPE { get; set; }

        public decimal WAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal COMPANYSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        [StringLength(64)]
        public string CUSTOMERID { get; set; }

        [StringLength(128)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(64)]
        public string CUSTOMERCLASS { get; set; }

        [StringLength(64)]
        public string CUSTOMERTYPE { get; set; }

        [StringLength(64)]
        public string SALESMANID { get; set; }

        [StringLength(64)]
        public string SALESMANTYPE { get; set; }

        [StringLength(128)]
        public string RCADDRESSDESC { get; set; }

        [StringLength(64)]
        public string RCPHONE { get; set; }

        [StringLength(64)]
        public string RCUSERNAME { get; set; }

        [StringLength(64)]
        public string RCZIP { get; set; }

        public decimal? RCAREAID { get; set; }

        [StringLength(512)]
        public string RCAREADESC { get; set; }

        [StringLength(64)]
        public string DELIVERYHUBID { get; set; }

        [StringLength(128)]
        public string DELIVERYHUBDESC { get; set; }

        public decimal? DELIVERYMETHODID { get; set; }

        [StringLength(256)]
        public string DELIVERYMETHODDESC { get; set; }

        public DateTime? CONFIRMEDDATETIME { get; set; }

        public decimal? WAVESYSNO { get; set; }

        [StringLength(32)]
        public string WAVENUM { get; set; }

        public decimal? DISPATCHNODESYSNO { get; set; }

        [StringLength(128)]
        public string DISPATCHNODENAME { get; set; }

        public DateTime? EXPECTOUTSTOCKDATETIME { get; set; }

        public DateTime? REALITYOUTSTOCKDATETIME { get; set; }

        public decimal? PAYMETHOD { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? PAYAMOUNT { get; set; }

        public decimal? INVOICESYSNO { get; set; }

        public decimal? ISAUTOINVOICE { get; set; }

        public decimal? INVOICETYPE { get; set; }

        public decimal? PRIORITY { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        public decimal? ZONECOUNT { get; set; }

        public decimal? ISCONTAINLARGEAPPLIANCES { get; set; }

        public decimal? ISCONTAINSERVICEPRODUCTS { get; set; }

        public decimal? ISCROSSWH { get; set; }

        public decimal? ISSEPARATEINVOICE { get; set; }

        public decimal? ISNEUTRALPACKING { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public DateTime? SODATE { get; set; }

        public DateTime? DELIVERYDATE { get; set; }

        public decimal? DELIVERYDATETIMESPAN { get; set; }

        public DateTime? AUDITTIME { get; set; }

        public decimal? AUDITDELIVERYTIMESPAN { get; set; }

        [StringLength(64)]
        public string RCMOBILEPHONE { get; set; }

        [StringLength(256)]
        public string DELIVERYMEMO { get; set; }

        public decimal? ISSIGNBYOTHERS { get; set; }

        [StringLength(64)]
        public string PAYMETHODNAME { get; set; }

        public decimal? ISALLOWPARTSHIP { get; set; }

        public decimal? NUM { get; set; }

        public decimal? ORDERSIZE { get; set; }

        [StringLength(64)]
        public string RCUSERNAME2 { get; set; }

        [StringLength(64)]
        public string RCPHONE2 { get; set; }

        public decimal? SHIPMENTSTATUS { get; set; }

        public decimal? SRCSYSTEM { get; set; }

        public decimal? ISSUSPEND { get; set; }

        [StringLength(1024)]
        public string SUSPENDREASON { get; set; }

        public decimal? ISVAT { get; set; }

        public decimal? ISHIDEAMOUNT { get; set; }

        [StringLength(32)]
        public string TOOTHERWAREHOSECODE { get; set; }

        public decimal? ISHAVEINVOICED { get; set; }

        [StringLength(16)]
        public string TICKETNAME { get; set; }

        public decimal? ISBINDDPS { get; set; }

        [StringLength(20)]
        public string IO_STATUS { get; set; }

        [StringLength(20)]
        public string LOGISTICS { get; set; }

        public decimal? WEIGHT { get; set; }

        [StringLength(20)]
        public string LOGISTICS_NO { get; set; }

        [StringLength(100)]
        public string PLANTCODE { get; set; }

        [StringLength(100)]
        public string PLANTNAME { get; set; }

        [StringLength(100)]
        public string SAPLOCATIONCODE { get; set; }

        [StringLength(100)]
        public string SAPLOCATIONNAME { get; set; }

        public decimal? COSSINGSYSNO { get; set; }

        [StringLength(50)]
        public string COSSINGNUM { get; set; }

        public decimal? POSTSAP { get; set; }

        [StringLength(50)]
        public string OTHERLGORT { get; set; }
    }
}
