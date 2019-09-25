namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.INVTRANSACTION")]
    public partial class INVTRANSACTION
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(32)]
        public string TRANID { get; set; }

        public decimal TRANTYPE { get; set; }

        [Required]
        [StringLength(32)]
        public string SYSTEMTRANTYPE { get; set; }

        [Required]
        [StringLength(32)]
        public string SYSTEMINVCHANGEPLANID { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(64)]
        public string WAREHOUSENAME { get; set; }

        [Required]
        [StringLength(64)]
        public string COMPANYCODE { get; set; }

        [StringLength(64)]
        public string LOCATIONFROM { get; set; }

        [StringLength(64)]
        public string LOCATIONTO { get; set; }

        [StringLength(64)]
        public string LPNFROM { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        public decimal? QTY { get; set; }

        public decimal? PACKDETAILSYSNO { get; set; }

        public decimal? ISWHOLEPLATE { get; set; }

        public decimal SOURCETYPE { get; set; }

        [Required]
        [StringLength(64)]
        public string SOURCEID { get; set; }

        [Required]
        [StringLength(64)]
        public string SOURCELINENO { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(64)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        public decimal? AVERAGE { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [StringLength(50)]
        public string UNITCODE { get; set; }

        [StringLength(50)]
        public string INVUNIT { get; set; }

        [StringLength(50)]
        public string INVUNITCODE { get; set; }

        public decimal? RECEIPTNUM { get; set; }
    }
}
