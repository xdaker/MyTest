namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_MATERIALSTORAGEAREA")]
    public partial class WMS_MATERIALSTORAGEAREA
    {
        [Key]
        [StringLength(36)]
        public string MATERIALSTORAGEAREAID { get; set; }

        [StringLength(36)]
        public string MATERIALSSORTSID { get; set; }

        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(36)]
        public string STORAGEAREAID { get; set; }

        [StringLength(36)]
        public string LANEID { get; set; }

        public int? STARTROW { get; set; }

        public int? ENDROW { get; set; }

        public int? STARTVERTICAL { get; set; }

        public int? ENDVERTICAL { get; set; }

        public int? STARTLAYER { get; set; }

        public int? ENDLAYER { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }
    }
}
