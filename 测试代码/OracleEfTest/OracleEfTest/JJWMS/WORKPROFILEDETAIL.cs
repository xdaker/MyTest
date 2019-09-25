namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WORKPROFILEDETAIL")]
    public partial class WORKPROFILEDETAIL
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal PROFILESYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [Required]
        [StringLength(32)]
        public string AREACODE { get; set; }

        public decimal WORKTYPE { get; set; }

        public decimal DIRECTTYPE { get; set; }

        [StringLength(64)]
        public string SORTINGCOLUMN { get; set; }

        public decimal? PRIORITY { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

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
    }
}
