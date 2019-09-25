namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.LOCATION")]
    public partial class LOCATION
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(32)]
        public string SECTION { get; set; }

        [Required]
        [StringLength(64)]
        public string AREACODE { get; set; }

        [StringLength(16)]
        public string PUTZONE { get; set; }

        [StringLength(16)]
        public string ALLOCZONE { get; set; }

        [StringLength(16)]
        public string CCZONE { get; set; }

        public decimal? HIGHVALUE { get; set; }

        public DateTime? LASTCCDATE { get; set; }

        [StringLength(64)]
        public string ALSLE { get; set; }

        [StringLength(16)]
        public string BAY { get; set; }

        [StringLength(16)]
        public string LEVELNO { get; set; }

        [StringLength(16)]
        public string POSITION { get; set; }

        public decimal? LENGTH { get; set; }

        public decimal? WIDTH { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? CUBE { get; set; }

        public decimal? WEIGHT { get; set; }

        [StringLength(64)]
        public string PICKINGSEQ { get; set; }

        [StringLength(64)]
        public string CCSEQ { get; set; }

        [StringLength(64)]
        public string PUTSEQ { get; set; }

        public decimal? INVENTORYSTS { get; set; }

        public decimal? LOCATIONSTS { get; set; }

        [StringLength(32)]
        public string LOCATIONCLASS { get; set; }

        public decimal? LOCATIONTYPE { get; set; }

        public decimal? MOVEMENTTYPE { get; set; }

        [StringLength(32)]
        public string CHECKDIGIT { get; set; }

        public decimal? XCOORD { get; set; }

        public decimal? YCOORD { get; set; }

        public decimal? ZCOORD { get; set; }

        public decimal COMMINGLESKU { get; set; }

        public decimal COMMINGLELOT { get; set; }

        public decimal ISLOSTLPN { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        public decimal? ENABLEFLAG { get; set; }

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

        public decimal? ISIGNORECAPACITY { get; set; }

        [Required]
        [StringLength(16)]
        public string ISSHOW { get; set; }

        [StringLength(16)]
        public string PARALLELISM_ST { get; set; }

        public decimal? DEFULTSKUSYSNO { get; set; }

        [StringLength(16)]
        public string DEFULTSKU { get; set; }

        [StringLength(16)]
        public string DEEP { get; set; }

        public decimal? ISDOUBLEEXTENSION { get; set; }

        public decimal? ISEXTENSION { get; set; }

        [StringLength(50)]
        public string ROADWAYNO { get; set; }

        public decimal? LC_ST { get; set; }

        public decimal? EXSTATE { get; set; }
    }
}
