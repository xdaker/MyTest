namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.STATION")]
    public partial class STATION
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string ST_NO { get; set; }

        [StringLength(64)]
        public string ST_DESC { get; set; }

        [Required]
        [StringLength(64)]
        public string AREACODE { get; set; }

        [StringLength(10)]
        public string ST_TYPE { get; set; }

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

        public decimal? IS_LOCK { get; set; }

        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(64)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(64)]
        public string WCS_ST_NO { get; set; }

        [StringLength(64)]
        public string WCS_ST_NO_IN { get; set; }

        [StringLength(64)]
        public string WCS_ST_NO_OUT { get; set; }
    }
}
