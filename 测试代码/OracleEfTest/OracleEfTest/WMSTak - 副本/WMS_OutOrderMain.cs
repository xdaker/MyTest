namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_OutOrderMain")]
    public partial class WMS_OutOrderMain
    {
        [Key]
        [StringLength(32)]
        public string OutOrderId { get; set; }

        [StringLength(48)]
        public string DeliveryId { get; set; }

        [StringLength(36)]
        public string ReceiveCompanyId { get; set; }

        [StringLength(32)]
        public string OrderId { get; set; }

        [StringLength(36)]
        public string UnloadId { get; set; }

        public DateTime? DownloadTime { get; set; }

        public int? IsAuditing { get; set; }

        public int? OrderProcess { get; set; }

        public int? CreateOrderType { get; set; }

        [StringLength(36)]
        public string SyncSystemId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

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
