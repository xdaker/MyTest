namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.ORDEREXCEPTIONLOG")]
    public partial class ORDEREXCEPTIONLOG
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal EXCEPTIONSYSNO { get; set; }

        [StringLength(128)]
        public string EXCEPTIONNUM { get; set; }

        [StringLength(128)]
        public string DEALNUM { get; set; }

        [StringLength(500)]
        public string DEALLOG { get; set; }

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

        [StringLength(500)]
        public string REASONDESC { get; set; }
    }
}
