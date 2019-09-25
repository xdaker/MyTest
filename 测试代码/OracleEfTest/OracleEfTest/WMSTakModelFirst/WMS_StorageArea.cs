namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_StorageArea")]
    public partial class WMS_StorageArea
    {
        [Key]
        [StringLength(36)]
        public string StorageAreaId { get; set; }

        [StringLength(32)]
        public string WarehouseCode { get; set; }

        [StringLength(16)]
        public string LocationFunctionCode { get; set; }

        [StringLength(32)]
        public string AreaName { get; set; }

        [StringLength(32)]
        public string AreaCode { get; set; }

        public int? TemperatureType { get; set; }

        [StringLength(32)]
        public string StorageAreaCode { get; set; }

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
