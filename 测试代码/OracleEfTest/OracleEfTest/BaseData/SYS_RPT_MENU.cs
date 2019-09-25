namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SYS_RPT_MENU")]
    public partial class SYS_RPT_MENU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string CODE { get; set; }

        [Required]
        [StringLength(128)]
        public string ACTNAME { get; set; }

        public long PARENTID { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        public decimal ENABLEFLAG { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(256)]
        public string RPTURL { get; set; }
    }
}
