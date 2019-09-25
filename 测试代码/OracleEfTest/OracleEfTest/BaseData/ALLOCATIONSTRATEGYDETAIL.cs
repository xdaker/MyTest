namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.ALLOCATIONSTRATEGYDETAIL")]
    public partial class ALLOCATIONSTRATEGYDETAIL
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal STRATEGYSYSNO { get; set; }

        public decimal LINENUM { get; set; }

        public decimal ORDERTYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string UMCODE { get; set; }

        public decimal LOCATIONFILTERSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string LOCATIONFILTERNAME { get; set; }

        public decimal ALLOCATIONRULE { get; set; }

        public decimal ENABLEFLAG { get; set; }

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

        public DateTime ROWCREATEDATE { get; set; }
    }
}
