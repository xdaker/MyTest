namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_STORAGEAREAMATERIALMAP")]
    public partial class WMS_STORAGEAREAMATERIALMAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPID { get; set; }

        [StringLength(36)]
        public string STORAGEAREAID { get; set; }

        [StringLength(32)]
        public string AREACODE { get; set; }

        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [StringLength(32)]
        public string MATERIALSCODE { get; set; }

        public decimal? MAXQUANTITY { get; set; }

        public decimal? MINQUANTITY { get; set; }

        public int? ISENABLE { get; set; }
    }
}
