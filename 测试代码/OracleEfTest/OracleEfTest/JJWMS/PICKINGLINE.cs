namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PICKINGLINE")]
    public partial class PICKINGLINE
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal? PICKINGSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string PICKINGNUM { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(1204)]
        public string SKUNAME { get; set; }

        [StringLength(128)]
        public string STYLE { get; set; }

        [StringLength(128)]
        public string MATERIAL { get; set; }

        [StringLength(64)]
        public string UNIT { get; set; }

        [StringLength(32)]
        public string UNITCODE { get; set; }

        public decimal? QTYORDERED { get; set; }

        public decimal? QTYPICKED { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        public decimal? PICKINGSTATUS { get; set; }

        [StringLength(500)]
        public string COMMENTS { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
