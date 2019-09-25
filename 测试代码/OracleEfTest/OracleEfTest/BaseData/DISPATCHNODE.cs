namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.DISPATCHNODE")]
    public partial class DISPATCHNODE
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        public string DESCRIPTION { get; set; }

        public decimal? WAREHOUSESYSNO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Key]
        [Column(Order = 4)]
        public string WAREHOUSENAME { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime NODETIME { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime RUNSTARTTIME { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime RUNENDTIME { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PRIORITY { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ENABLEFLAG { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
