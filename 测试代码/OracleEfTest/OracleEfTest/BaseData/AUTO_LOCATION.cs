namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.AUTO_LOCATION")]
    public partial class AUTO_LOCATION
    {
        public decimal SYSNO { get; set; }

        [Key]
        [StringLength(64)]
        public string LOC_NO { get; set; }

        [StringLength(64)]
        public string ALSLE { get; set; }

        [StringLength(16)]
        public string BAY { get; set; }

        [StringLength(16)]
        public string LEVELNO { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        public decimal? ENABLEFLAG { get; set; }

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

        [StringLength(2)]
        public string LC_ST { get; set; }

        [StringLength(20)]
        public string LPN_NO { get; set; }

        [StringLength(20)]
        public string DVC_NO { get; set; }

        [StringLength(64)]
        public string SKU_NO { get; set; }
    }
}
