namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_CheckMain")]
    public partial class WMS_CheckMain
    {
        [Key]
        [StringLength(36)]
        public string CheckCode { get; set; }

        [StringLength(32)]
        public string CheckPlanMainId { get; set; }

        [StringLength(32)]
        public string CheckStockNum { get; set; }

        public DateTime? CheckDate { get; set; }

        public int? CheckMode { get; set; }

        [StringLength(28)]
        public string ContainerCode { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        public int? IsFull { get; set; }

        public int? IsTaskCompleted { get; set; }

        public int? SelectLocationType { get; set; }

        [StringLength(36)]
        public string OperatorId { get; set; }

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
