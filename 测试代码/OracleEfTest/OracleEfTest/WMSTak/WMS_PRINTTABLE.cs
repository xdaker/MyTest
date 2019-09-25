namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_PRINTTABLE")]
    public partial class WMS_PRINTTABLE
    {
        [Key]
        [StringLength(36)]
        public string PRINTID { get; set; }

        [StringLength(36)]
        public string CONTAINERCODE { get; set; }

        public int? PRINTTYPE { get; set; }

        public int? TASKTYPE { get; set; }

        [StringLength(32)]
        public string MATERIALSCODE { get; set; }

        [StringLength(64)]
        public string MATERIALSNAME { get; set; }

        [StringLength(52)]
        public string FIGURENUMBER { get; set; }

        [StringLength(32)]
        public string PACKMODEL { get; set; }

        [StringLength(32)]
        public string MATERIALSATTRIBUTE { get; set; }

        [StringLength(32)]
        public string PRODUCTBATCH { get; set; }

        public decimal? QUANTITY { get; set; }

        [StringLength(64)]
        public string PRODUCTNAME { get; set; }

        [StringLength(64)]
        public string PRODUCTCODE { get; set; }

        [StringLength(10)]
        public string MATUREDATE { get; set; }

        [StringLength(10)]
        public string FLAG { get; set; }

        public DateTime? INDATE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(36)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(36)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }
    }
}
