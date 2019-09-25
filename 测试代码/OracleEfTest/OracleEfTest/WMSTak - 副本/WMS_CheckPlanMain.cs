namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_CheckPlanMain")]
    public partial class WMS_CheckPlanMain
    {
        [Key]
        [StringLength(32)]
        public string CheckPlanMainId { get; set; }

        public DateTime? DownloadTime { get; set; }

        public int? CreatePlanType { get; set; }

        public int? CheckType { get; set; }

        public int? IsProcess { get; set; }

        public int? IsAuditing { get; set; }

        [StringLength(36)]
        public string AuditUserId { get; set; }

        public DateTime? AuditDate { get; set; }

        [StringLength(36)]
        public string SyncSystemId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(1000)]
        public string Attribute3 { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
