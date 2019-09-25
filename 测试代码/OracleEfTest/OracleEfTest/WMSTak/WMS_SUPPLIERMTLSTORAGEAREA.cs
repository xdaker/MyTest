namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_SUPPLIERMTLSTORAGEAREA")]
    public partial class WMS_SUPPLIERMTLSTORAGEAREA
    {
        [Key]
        [StringLength(36)]
        public string SUPPLIERMATERIALSSTORAGEAREAID { get; set; }

        [StringLength(36)]
        public string BUSINESSID { get; set; }

        [StringLength(36)]
        public string MATERIALSID { get; set; }

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

        [StringLength(36)]
        public string CREATEUSERID { get; set; }

        [StringLength(32)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(36)]
        public string MODIFYUSERID { get; set; }

        [StringLength(32)]
        public string MODIFYUSERNAME { get; set; }
    }
}
