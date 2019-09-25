namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_PrintTable")]
    public partial class WMS_PrintTable
    {
        [Key]
        [StringLength(36)]
        public string PrintId { get; set; }

        [StringLength(36)]
        public string ContainerCode { get; set; }

        public int? PrintType { get; set; }

        public int? TaskType { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        [StringLength(64)]
        public string MaterialsName { get; set; }

        [StringLength(52)]
        public string FigureNumber { get; set; }

        [StringLength(32)]
        public string PackModel { get; set; }

        [StringLength(32)]
        public string MaterialsAttribute { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        
        public decimal? Quantity { get; set; }

        [StringLength(64)]
        public string ProductName { get; set; }

        [StringLength(64)]
        public string ProductCode { get; set; }

        [StringLength(10)]
        public string MatureDate { get; set; }

        [StringLength(10)]
        public string Flag { get; set; }

        public DateTime? InDate { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(80)]
        public string Attribute3 { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(36)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(36)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
