namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_SupplierMtlStorageArea")]
    public partial class WMS_SupplierMaterialsStorageArea
    {
        [Key]
        [StringLength(36)]
        public string SupplierMaterialsStorageAreaId { get; set; }

        [StringLength(36)]
        public string BusinessId { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(32)]
        public string WarehouseCode { get; set; }

        [StringLength(36)]
        public string StorageAreaId { get; set; }

        [StringLength(36)]
        public string LaneId { get; set; }

        public int? StartRow { get; set; }

        public int? EndRow { get; set; }

        public int? StartVertical { get; set; }

        public int? EndVertical { get; set; }

        public int? StartLayer { get; set; }

        public int? EndLayer { get; set; }

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

        [StringLength(32)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(36)]
        public string ModifyUserId { get; set; }

        [StringLength(32)]
        public string ModifyUserName { get; set; }
    }
}
