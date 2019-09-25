namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.LOTRECORDS")]
    public partial class LOTRECORDS
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal? LOTATTRSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        public decimal SKUSYSNO { get; set; }

        public decimal COMPANYSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string PACKCODE { get; set; }

        [StringLength(128)]
        public string VALUEDESC { get; set; }

        [Required]
        [StringLength(64)]
        public string MD5 { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }
    }
}
