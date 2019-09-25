namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_BusinessInfo")]
    public partial class WMS_BusinessInfo
    {
        [Key]
        [StringLength(36)]
        public string BusinessId { get; set; }

        [StringLength(32)]
        public string BusinessCode { get; set; }

        [StringLength(36)]
        public string BusinessType { get; set; }

        [StringLength(64)]
        public string BusinessName { get; set; }

        [StringLength(32)]
        public string ShortName { get; set; }

        [StringLength(1000)]
        public string BusinessDescription { get; set; }

        [StringLength(800)]
        public string Address { get; set; }

        [StringLength(16)]
        public string Phone1 { get; set; }

        [StringLength(16)]
        public string Phone2 { get; set; }

        [StringLength(16)]
        public string Fax { get; set; }

        [StringLength(36)]
        public string Web { get; set; }

        [StringLength(36)]
        public string Email { get; set; }

        [StringLength(16)]
        public string Linkman1 { get; set; }

        [StringLength(16)]
        public string Linkman2 { get; set; }

        public int? Status { get; set; }

        [StringLength(36)]
        public string PYCode { get; set; }

        [StringLength(36)]
        public string SyncSystemId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

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
