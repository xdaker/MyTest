namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.RECEIPTLINE")]
    public partial class RECEIPTLINE
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal RECEIPTSYSNO { get; set; }

        public decimal SKUSYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(1024)]
        public string SKUNAME { get; set; }

        public decimal COMPANYSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public decimal WAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal RECEIPTSTATUS { get; set; }

        [StringLength(50)]
        public string UMCODE { get; set; }

        [StringLength(50)]
        public string PACKCODE { get; set; }

        public decimal EXPECTEDQTY { get; set; }

        public decimal RECEIVEDQTY { get; set; }

        public decimal ADJUSTEDQTY { get; set; }

        public decimal? PNFLAG { get; set; }

        public decimal? SERIALNOFLAG { get; set; }

        [StringLength(32)]
        public string LINENUM { get; set; }

        public decimal? ISDELETE { get; set; }

        public decimal? ISICSONNOPRINTED { get; set; }

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

        public decimal? ISWQFREENOPRINTED { get; set; }

        [StringLength(50)]
        public string WEIGHTUNIT { get; set; }

        [StringLength(50)]
        public string WEIGHTUNITCODE { get; set; }

        public decimal? AVERAGEWEIGHT { get; set; }

        [StringLength(50)]
        public string NUMUNIT { get; set; }

        public decimal? INVNUMBER { get; set; }

        public decimal? VENDORSYSNO { get; set; }

        [StringLength(32)]
        public string VENDORCODE { get; set; }

        [StringLength(128)]
        public string VENDORNAME { get; set; }

        [StringLength(64)]
        public string STYLE { get; set; }

        [StringLength(64)]
        public string TAXRATE { get; set; }

        public decimal? COLLECTTYPE { get; set; }

        [StringLength(32)]
        public string RETURNNUM { get; set; }

        public decimal? RETURNQTY { get; set; }

        public decimal? SEQ { get; set; }

        public decimal? ISURGENT { get; set; }

        public decimal? ORDERQUANTITY { get; set; }

        public decimal? APPLICATIONSQUANTITY { get; set; }

        public decimal? STORAGEQUANTITY { get; set; }

        [StringLength(1024)]
        public string RETURNMATERIALREASON { get; set; }

        public decimal? SORTNUMBER { get; set; }

        [StringLength(150)]
        public string DELIVERYWAREHOUSECODE { get; set; }

        [StringLength(150)]
        public string DELIVERYWAREHOUSENAME { get; set; }
    }
}
