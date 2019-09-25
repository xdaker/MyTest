namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_Tasks")]
    public partial class WMS_Tasks
    {
        [Key]
        [StringLength(36)]
        public string TaskCode { get; set; }

        [StringLength(16)]
        public string TypeCode { get; set; }

        [StringLength(32)]
        public string GlideCode { get; set; }

        [StringLength(36)]
        public string OperaterId { get; set; }

        [StringLength(36)]
        public string StartLocationId { get; set; }

        [StringLength(36)]
        public string EndLocationId { get; set; }

        public DateTime? DownTime { get; set; }

        public DateTime? CompleteTime { get; set; }

        [StringLength(26)]
        public string ContainerCode { get; set; }

        [StringLength(32)]
        public string BillsId { get; set; }

        public int? Priority { get; set; }

        public int? TaskTroubleStatus { get; set; }

        public int? DownCode { get; set; }

        public int? SetType { get; set; }

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
