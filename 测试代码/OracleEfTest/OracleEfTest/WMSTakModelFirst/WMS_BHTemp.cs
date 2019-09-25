namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_BHTemp")]
    public partial class WMS_BHTemp
    {
        [Key]
        [StringLength(36)]
        public string OutTempId { get; set; }

        [StringLength(32)]
        public string OutCode { get; set; }

        [StringLength(28)]
        public string JHContainerCode { get; set; }

        [StringLength(28)]
        public string ContainerCode { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        public int? OutMode { get; set; }

        [StringLength(32)]
        public string OutPlanId { get; set; }

        [StringLength(36)]
        public string OutPlanDetailId { get; set; }

        public decimal? OutQuantity { get; set; }

        public int? flag { get; set; }

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

        [StringLength(36)]
        public string StockpileId { get; set; }
    }
}
