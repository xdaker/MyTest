namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SAPOUTUPLOADBODY")]
    public partial class SAPOUTUPLOADBODY
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal SAPOUTUPLOADNO { get; set; }

        public decimal? QUANTITY { get; set; }

        [StringLength(50)]
        public string SEL { get; set; }

        [StringLength(50)]
        public string LINE { get; set; }

        [StringLength(50)]
        public string MENGER { get; set; }

        [StringLength(50)]
        public string SERIAL { get; set; }

        public decimal? OUTTYPE { get; set; }

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
    }
}
