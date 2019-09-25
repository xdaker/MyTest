namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PICKING")]
    public partial class PICKING
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(50)]
        public string PICKINGNUM { get; set; }

        public decimal? PICKINGTYPE { get; set; }

        public decimal? BUSINESSTYPE { get; set; }

        public decimal? WORKSTATUS { get; set; }

        [StringLength(64)]
        public string PICKDATE { get; set; }

        [StringLength(64)]
        public string PICKINGER { get; set; }

        [StringLength(32)]
        public string CUSTOMERID { get; set; }

        [StringLength(64)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(200)]
        public string RCPHONE { get; set; }

        [StringLength(500)]
        public string RCADDRESSDESC { get; set; }

        [StringLength(500)]
        public string COMMENTS { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(64)]
        public string RCUSERNAME { get; set; }
    }
}
