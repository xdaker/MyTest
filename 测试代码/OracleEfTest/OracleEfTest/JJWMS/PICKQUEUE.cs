namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PICKQUEUE")]
    public partial class PICKQUEUE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SYSNO { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [Required]
        [StringLength(64)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public long SKUSYSNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(256)]
        public string SKUNAME { get; set; }

        [Required]
        [StringLength(32)]
        public string ORDERNUM { get; set; }

        [StringLength(64)]
        public string WAVENUM { get; set; }

        [Required]
        [StringLength(32)]
        public string LOCATIONCODE { get; set; }

        [StringLength(32)]
        public string ZONECODE { get; set; }

        [StringLength(32)]
        public string LOCATIONTOCODE { get; set; }

        [StringLength(64)]
        public string LOT { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        [StringLength(64)]
        public string PACKCODE { get; set; }

        public long? PACKDETAILSYSNO { get; set; }

        [StringLength(10)]
        public string UMCODE { get; set; }

        public long? TASKID { get; set; }

        [StringLength(64)]
        public string CARTONTO { get; set; }

        public decimal QTY { get; set; }

        public decimal QTYPICKED { get; set; }

        public decimal QTYSORTED { get; set; }

        public decimal QTYPACKED { get; set; }

        public decimal QTYSHIPPED { get; set; }

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

        public decimal? ENGINEID { get; set; }

        public int? DEALSTATUS { get; set; }

        public int? RV { get; set; }

        public int? UPDATEVERSION { get; set; }

        public int? WAVEID { get; set; }

        public int? ORDERSYSNO { get; set; }

        public int? CHANGEPLANSYSNO { get; set; }

        public int? LOCATIONSYSNO { get; set; }

        [StringLength(32)]
        public string AREACODE { get; set; }

        public int? ORDERLINESYSNO { get; set; }

        public int? PICKID { get; set; }

        public decimal QTYCHANGE { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        public int? INV_ID { get; set; }
    }
}
