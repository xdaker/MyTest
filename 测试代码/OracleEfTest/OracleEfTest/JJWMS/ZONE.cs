namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.ZONE")]
    public partial class ZONE
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string CODE { get; set; }

        [Required]
        [StringLength(128)]
        public string DESCRIPTION { get; set; }

        public decimal ZONETYPE { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(64)]
        public string INLOC { get; set; }

        [StringLength(64)]
        public string OUTLOC { get; set; }

        public decimal CHECKMETHOD { get; set; }

        public decimal PICKMETHOD { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        public decimal? XCOORD { get; set; }

        public decimal? YCOORD { get; set; }

        public decimal? ZCOORD { get; set; }

        public decimal ENABLEFLAG { get; set; }

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

        public decimal ISCOLLECT { get; set; }
    }
}
