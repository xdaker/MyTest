namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.CONTRACT")]
    public partial class CONTRACT
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORIGINSYSNO { get; set; }

        [StringLength(64)]
        public string ACTNAME { get; set; }

        [StringLength(64)]
        public string PHONE { get; set; }

        [StringLength(64)]
        public string MOBILE { get; set; }

        [StringLength(64)]
        public string FAX { get; set; }

        [StringLength(64)]
        public string EMAIL { get; set; }

        public decimal? ISDEFAULT { get; set; }

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
    }
}
