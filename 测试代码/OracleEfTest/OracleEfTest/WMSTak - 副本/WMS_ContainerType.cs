namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_ContainerType")]
    public partial class WMS_ContainerType
    {
        [Key]
        [StringLength(36)]
        public string ContainerTypeId { get; set; }

        [StringLength(32)]
        public string ContainerTypeCode { get; set; }

        [StringLength(32)]
        public string ContainerTypeName { get; set; }

        
        public decimal? Length { get; set; }

        
        public decimal? Width { get; set; }

        
        public decimal? High { get; set; }

        [StringLength(8)]
        public string Unit { get; set; }

        public int? Status { get; set; }

        public int? IsControl { get; set; }

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
