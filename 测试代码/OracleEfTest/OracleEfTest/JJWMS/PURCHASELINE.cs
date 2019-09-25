namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PURCHASELINE")]
    public partial class PURCHASELINE
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(200)]
        public string SKUNAME { get; set; }

        [StringLength(200)]
        public string MATERIAL { get; set; }

        [StringLength(100)]
        public string STYLE { get; set; }

        public decimal PURCHASESYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string PURCHASESRCNUM { get; set; }

        [Required]
        [StringLength(100)]
        public string VENDORCODE { get; set; }

        [Required]
        [StringLength(200)]
        public string VENDORNAME { get; set; }

        [StringLength(100)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(200)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(50)]
        public string COMPANYSYSNO { get; set; }

        [StringLength(100)]
        public string COMPANYCODE { get; set; }

        [StringLength(100)]
        public string COMPANYNAME { get; set; }

        public decimal SKUSTATUS { get; set; }

        public decimal ALLQTY { get; set; }

        public decimal PURCHASEWEIGHT { get; set; }

        [Required]
        [StringLength(50)]
        public string WEIGHTUNIT { get; set; }

        [StringLength(50)]
        public string UMCODE { get; set; }

        public decimal QTY { get; set; }

        public decimal ISEXCEED { get; set; }

        public decimal STAYWEIGHT { get; set; }

        public decimal ALREADYWEIGHT { get; set; }

        [StringLength(100)]
        public string FILE1 { get; set; }

        public decimal? FILE2 { get; set; }

        public decimal? FILE3 { get; set; }

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

        [StringLength(320)]
        public string REMARKS { get; set; }

        [StringLength(150)]
        public string ISURGEN { get; set; }

        [StringLength(150)]
        public string UNIT { get; set; }
    }
}
