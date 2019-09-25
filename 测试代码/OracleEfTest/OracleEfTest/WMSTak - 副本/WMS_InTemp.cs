namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_InTemp")]
    public partial class WMS_InTemp
    {
        [Key]
        [StringLength(36)]
        public string InTempId { get; set; }

        [StringLength(32)]
        public string InPlanId { get; set; }

        [StringLength(36)]
        public string InPlanDetailId { get; set; }

        [StringLength(28)]
        public string ContainerCode { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        
        public decimal? InQuantity { get; set; }

        public int? InType { get; set; }

        public int? flag { get; set; }

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
