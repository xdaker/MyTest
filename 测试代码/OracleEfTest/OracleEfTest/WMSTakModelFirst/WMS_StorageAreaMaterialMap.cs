namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_StorageAreaMaterialMap")]
    public partial class WMS_StorageAreaMaterialMap
    {
        [StringLength(36)]
        public string StorageAreaId { get; set; }

        [StringLength(32)]
        public string AreaCode { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        
        public decimal? MaxQuantity { get; set; }

        
        public decimal? MinQuantity { get; set; }

        [Key]
        public int MapId { get; set; }

        public int? IsEnable { get; set; }
    }
}
