namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_TasksTemp")]
    public partial class WMS_TasksTemp
    {
        [Key]
        [StringLength(36)]
        public string TaskTempCode { get; set; }

        [StringLength(36)]
        public string TaskTempId { get; set; }

        [StringLength(32)]
        public string GlideCode { get; set; }

        [StringLength(36)]
        public string StartLocationId { get; set; }

        [StringLength(36)]
        public string EndLocationId { get; set; }

        public DateTime? DownTime { get; set; }

        public int? TaskStatus { get; set; }

        [StringLength(28)]
        public string ContainerCode { get; set; }

        public int? Priority { get; set; }

        public int? IsInsert { get; set; }

        public int? IsPause { get; set; }

        public int? DownCode { get; set; }

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

        public virtual WMS_TasksMainTemp WMS_TasksMainTemp { get; set; }
    }
}
