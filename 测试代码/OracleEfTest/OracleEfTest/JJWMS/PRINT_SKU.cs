namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PRINT_SKU")]
    public partial class PRINT_SKU
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string SKU_NO { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(64)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [StringLength(100)]
        public string COMMENTS { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(64)]
        public string MODIFYUSERID { get; set; }

        public decimal? MODIFYUSERNAME { get; set; }

        public decimal? ENABLEFLAG { get; set; }

        public decimal CURRENT_NO { get; set; }

        public decimal? SKUSYSNO { get; set; }
    }
}
