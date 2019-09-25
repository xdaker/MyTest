namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.PLANT")]
    public partial class PLANT
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(50)]
        public string CHANGQUCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CHANGQUNAME { get; set; }

        [StringLength(50)]
        public string COMPANYCODE { get; set; }

        [StringLength(50)]
        public string COMPANYNAME { get; set; }

        [StringLength(50)]
        public string ORGCODE { get; set; }

        [StringLength(50)]
        public string ORGNAME { get; set; }

        [StringLength(50)]
        public string FUZERENCODE { get; set; }

        [StringLength(50)]
        public string FUZERENNAME { get; set; }

        public decimal? OPERATESTATUS { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

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

        [StringLength(320)]
        public string REMARKS { get; set; }
    }
}
