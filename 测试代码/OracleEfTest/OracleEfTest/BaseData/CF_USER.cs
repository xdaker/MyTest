namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.CF_USER")]
    public partial class CF_USER
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(128)]
        public string AUTHNAME { get; set; }

        public decimal DEFAULTWAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string DEFAULTWAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string DEFAULTWAREHOUSENAME { get; set; }

        public decimal? WORKPROFILESYSNO { get; set; }

        [StringLength(32)]
        public string WORKPROFILECODE { get; set; }

        [StringLength(128)]
        public string WORKPROFILEDESC { get; set; }

        public decimal ENABLEFLAG { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(300)]
        public string ACTNAME { get; set; }

        [StringLength(300)]
        public string USERPWD { get; set; }

        public decimal ISADMIN { get; set; }

        [StringLength(200)]
        public string COMMENTS { get; set; }
    }
}
