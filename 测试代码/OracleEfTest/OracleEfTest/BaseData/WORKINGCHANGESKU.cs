namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WORKINGCHANGESKU")]
    public partial class WORKINGCHANGESKU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SYSNO { get; set; }

        public long? TASKID { get; set; }

        [StringLength(10)]
        public string STATUS { get; set; }

        public long? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUNAME { get; set; }

        [StringLength(32)]
        public string LOCATIONFROM { get; set; }

        [StringLength(32)]
        public string LOCATIONTO { get; set; }

        [StringLength(64)]
        public string LOT { get; set; }

        [StringLength(64)]
        public string LPNFROM { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        [StringLength(64)]
        public string TEMPLPN { get; set; }

        public decimal? QTY { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public long? ORDERSYSNO { get; set; }

        public long? ORDERLINESYSNO { get; set; }

        public long? INV_ID { get; set; }

        [StringLength(32)]
        public string OPERTYPE { get; set; }

        public decimal? COMPLETEDQTY { get; set; }

        [StringLength(100)]
        public string EXTERNORDERID { get; set; }

        [StringLength(100)]
        public string WAVENO { get; set; }

        [StringLength(100)]
        public string ORDERNUM { get; set; }

        [StringLength(10)]
        public string TASKTYPE { get; set; }
    }
}
