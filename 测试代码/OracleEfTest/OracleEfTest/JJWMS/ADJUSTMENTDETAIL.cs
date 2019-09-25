namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.ADJUSTMENTDETAIL")]
    public partial class ADJUSTMENTDETAIL
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal ADJUSTMENTSYSNO { get; set; }

        [Required]
        [StringLength(50)]
        public string EXTERNADJUSTMENTNUM { get; set; }

        public decimal? DETAILNUM { get; set; }

        public decimal STATUS { get; set; }

        public decimal? WAREHOUSESYSNO { get; set; }

        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal? COMPANYSYSNO { get; set; }

        [StringLength(64)]
        public string COMPANYCODE { get; set; }

        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public decimal SKUSYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string SKUDESC { get; set; }

        public decimal QTY { get; set; }

        public decimal LOCATIONSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        [StringLength(64)]
        public string LOTNUMBER { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

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

        public decimal? INVCHANGEPLANSYSNO { get; set; }
    }
}
