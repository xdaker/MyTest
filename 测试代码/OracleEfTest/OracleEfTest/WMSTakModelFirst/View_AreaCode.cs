namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.View_AreaCode")]
    public partial class View_AreaCode
    {
        [StringLength(32)]
        public string MaterialsCode { get; set; }

        [StringLength(32)]
        public string BusinessCode { get; set; }

        [StringLength(32)]
        public string AreaCode { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string MaterialsId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string BusinessId { get; set; }

        [StringLength(16)]
        public string LocationCode { get; set; }
    }
}
