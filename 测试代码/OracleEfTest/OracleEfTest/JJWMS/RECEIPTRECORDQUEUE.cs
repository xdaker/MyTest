namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.RECEIPTRECORDQUEUE")]
    public partial class RECEIPTRECORDQUEUE
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal SOURCETYPE { get; set; }

        public decimal? RECEIPTTYPE { get; set; }

        [Required]
        [StringLength(32)]
        public string SOURCEID { get; set; }

        public decimal SOURCELINENO { get; set; }

        public decimal? RECEIPTSYSNO { get; set; }

        public decimal RECEIPTLINESYSNO { get; set; }

        public decimal SKUSYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(1024)]
        public string SKUNAME { get; set; }

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

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal LOCATIONSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string LOCATIONCODE { get; set; }

        public decimal PACKDETAILSYSNO { get; set; }

        public decimal LOTRECORDSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        [StringLength(32)]
        public string LPNCODE { get; set; }

        [StringLength(2)]
        public string UMCODE { get; set; }

        [StringLength(64)]
        public string UMCODEDESC { get; set; }

        public decimal? UMQTY { get; set; }

        public decimal QTY { get; set; }

        public DateTime? LASTPROCESSTIME { get; set; }

        public decimal? STATUS { get; set; }

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

        public decimal? ENGINEID { get; set; }

        public decimal? DEALSTATUS { get; set; }

        public DateTime? RV { get; set; }

        public decimal? UPDATEVERSION { get; set; }

        [StringLength(32)]
        public string LOCATIONFROM { get; set; }

        [StringLength(32)]
        public string LOCATIONTO { get; set; }

        [StringLength(32)]
        public string AREACODE { get; set; }

        [StringLength(32)]
        public string PICKINGSEQ { get; set; }

        [StringLength(32)]
        public string PUTSEQ { get; set; }

        [StringLength(32)]
        public string CCSEQ { get; set; }

        [StringLength(32)]
        public string ZONECODE { get; set; }

        [Required]
        [StringLength(64)]
        public string PACKCODE { get; set; }

        [Required]
        [StringLength(32)]
        public string SOURCEEXTERNID { get; set; }

        [StringLength(10)]
        public string RECIPTSTYLE { get; set; }

        public decimal? RECEIPTNUM { get; set; }

        public decimal? AVERAGE { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [StringLength(50)]
        public string UNITCODE { get; set; }

        [StringLength(50)]
        public string INVUNIT { get; set; }

        [StringLength(50)]
        public string INVUNITCODE { get; set; }

        public decimal? VENDORSYSNO { get; set; }

        [StringLength(32)]
        public string VENDORCODE { get; set; }

        [StringLength(128)]
        public string VENDORNAME { get; set; }
    }
}
