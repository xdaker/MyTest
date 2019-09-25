namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SAPZIT_ALV")]
    public partial class SAPZIT_ALV
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(50)]
        public string VBELN { get; set; }

        [StringLength(50)]
        public string POSNR { get; set; }

        [StringLength(50)]
        public string MATNR { get; set; }

        [StringLength(50)]
        public string MAKTX { get; set; }

        [StringLength(50)]
        public string MVGR1 { get; set; }

        [StringLength(50)]
        public string BEZEI1 { get; set; }

        [StringLength(50)]
        public string MVGR2 { get; set; }

        [StringLength(50)]
        public string BEZEI2 { get; set; }

        [StringLength(50)]
        public string LIFSP { get; set; }

        [StringLength(50)]
        public string LIFSK { get; set; }

        [StringLength(50)]
        public string LIFSP1 { get; set; }

        [StringLength(50)]
        public string EDATU { get; set; }

        [StringLength(50)]
        public string ZWJHSL { get; set; }

        [StringLength(50)]
        public string SORTL { get; set; }

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

        [StringLength(320)]
        public string REMARKS { get; set; }

        [StringLength(50)]
        public string KUNNR { get; set; }

        [StringLength(50)]
        public string ARKTX { get; set; }

        [StringLength(50)]
        public string VRKME { get; set; }
    }
}
