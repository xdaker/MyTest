namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_InPlanMain")]
    public partial class WMS_InPlanMain
    {
        [Key]
        [StringLength(32)]
        public string InPlanId { get; set; }

        [StringLength(48)]
        public string DeliveryId { get; set; }

        public DateTime? DownloadTime { get; set; }

        public int? IsAuditing { get; set; }

        public int? IsProcess { get; set; }

        public int? CreatePlanType { get; set; }

        [StringLength(36)]
        public string SupplierId { get; set; }

        [StringLength(36)]
        public string SyncSystemId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

        public int? Flag { get; set; }

        public int? Status { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(80)]
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
