namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_TASKDETAILORDER")]
    public partial class V_TASKDETAILORDER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TASKDETAILSYSNO { get; set; }

        public long? WAVEID { get; set; }

        [StringLength(64)]
        public string WAVENUM { get; set; }

        public long? SKUSYSNO { get; set; }

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

        public DateTime? STARTTIME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        public decimal? ORDERLINETYPE { get; set; }

        [StringLength(100)]
        public string CARDNUMBER { get; set; }

        [StringLength(32)]
        public string DETAILID { get; set; }

        [StringLength(32)]
        public string PACKAGEID { get; set; }

        [StringLength(1)]
        public string IS_LINE { get; set; }

        [StringLength(1)]
        public string IS_AUDIT { get; set; }

        [StringLength(4)]
        public string CARDTYPE { get; set; }

        [StringLength(64)]
        public string ORDERCITY { get; set; }

        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [StringLength(20)]
        public string LOGISTICS { get; set; }

        public decimal? WEIGHT { get; set; }

        [StringLength(20)]
        public string IO_STATUS { get; set; }

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
