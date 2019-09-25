namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WAVEFLOWDETAIL")]
    public partial class WAVEFLOWDETAIL
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal WAVEFLOWSYSNO { get; set; }

        [StringLength(32)]
        public string WAVEFLOWCODE { get; set; }

        [StringLength(128)]
        public string WAVEFLOWDESC { get; set; }

        [StringLength(32)]
        public string CODE { get; set; }

        public decimal SEQUENCE { get; set; }

        public decimal STEP { get; set; }

        public decimal ENABLEFLAG { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

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
    }
}
