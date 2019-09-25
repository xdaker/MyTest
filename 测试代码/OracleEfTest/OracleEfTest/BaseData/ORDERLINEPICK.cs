namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.ORDERLINEPICK")]
    public partial class ORDERLINEPICK
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal? ORDERSYSNO { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        public decimal? ORDERTYPE { get; set; }

        public decimal? ORDERLINESYSNO { get; set; }

        public decimal? SKUNO { get; set; }

        [StringLength(50)]
        public string SKUCODE { get; set; }

        [StringLength(50)]
        public string QCODE { get; set; }

        public decimal? WORKSTATUS { get; set; }

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
        public string LOCATIONCODE { get; set; }
    }
}
