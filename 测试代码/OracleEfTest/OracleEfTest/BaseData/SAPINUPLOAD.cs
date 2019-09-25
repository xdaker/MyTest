namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SAPINUPLOAD")]
    public partial class SAPINUPLOAD
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(50)]
        public string WERKS { get; set; }

        public DateTime? BUDAT { get; set; }

        [StringLength(50)]
        public string LGORT { get; set; }

        [StringLength(50)]
        public string MATNR { get; set; }

        [StringLength(50)]
        public string MAKTX { get; set; }

        [StringLength(50)]
        public string SERGE { get; set; }

        public DateTime? INBDT { get; set; }

        public DateTime? ANSDT { get; set; }

        [StringLength(50)]
        public string MENGE { get; set; }

        [StringLength(50)]
        public string SERLV { get; set; }

        [StringLength(50)]
        public string ZBZ { get; set; }

        [StringLength(50)]
        public string LINE { get; set; }

        public decimal? QUANTITY { get; set; }

        [StringLength(50)]
        public string SERIAL { get; set; }

        public decimal? INTYPE { get; set; }

        public decimal? UPSTATUS { get; set; }

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

        [StringLength(100)]
        public string WERKSSYSNO { get; set; }

        [StringLength(50)]
        public string DOCORDERNO { get; set; }

        [StringLength(50)]
        public string OLDDOCORDERNO { get; set; }

        [StringLength(50)]
        public string OTHERLGORT { get; set; }

        [StringLength(2000)]
        public string SAPREMES { get; set; }
    }
}
