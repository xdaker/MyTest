namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_DPS_TASK")]
    public partial class V_DPS_TASK
    {
        public decimal? RN { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TASKDETAILSYSNO { get; set; }

        public long? WAVEID { get; set; }

        [StringLength(64)]
        public string WAVENUM { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUNAME { get; set; }

        public decimal? QTY { get; set; }

        [StringLength(32)]
        public string LOCATIONFROM { get; set; }

        [StringLength(64)]
        public string LPNFROM { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        [StringLength(64)]
        public string LOT { get; set; }

        [StringLength(32)]
        public string AREACODE { get; set; }

        [StringLength(32)]
        public string ASSIGNUSERID { get; set; }

        [StringLength(64)]
        public string ASSIGNUSERNAME { get; set; }

        public long? TASKTYPE { get; set; }

        public long? TRANTYPE { get; set; }

        public long? CONFIRMTYPE { get; set; }

        [StringLength(10)]
        public string STATUS { get; set; }

        public decimal? COMPLETEDQTY { get; set; }

        [StringLength(32)]
        public string LOCATIONTO { get; set; }

        [StringLength(32)]
        public string ZONECODE { get; set; }

        public long? ZONESYSNO { get; set; }

        [StringLength(32)]
        public string PAGENUMBER { get; set; }

        public long? ORDERSYSNO { get; set; }

        public long? ORDERLINESYSNO { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        public decimal? ORDERLINETYPE { get; set; }

        [StringLength(4)]
        public string CARDTYPE { get; set; }

        [StringLength(64)]
        public string ORDERCITY { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [StringLength(16)]
        public string PARALLELISM_ST { get; set; }

        public decimal? WORKSTATUS { get; set; }

        [StringLength(128)]
        public string RCADDRESSDESC { get; set; }

        public decimal? ISBINDDPS { get; set; }

        [StringLength(64)]
        public string EXTERNORDERID { get; set; }

        public decimal? WORKISOVER { get; set; }

        [StringLength(100)]
        public string PRODUCTTYPE { get; set; }

        [StringLength(20)]
        public string PROCESSINGTYPE { get; set; }

        [StringLength(200)]
        public string WORKCOMMENTS { get; set; }
    }
}
