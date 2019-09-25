namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.VIEW_AREACODE")]
    public partial class VIEW_AREACODE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string BUSINESSID { get; set; }

        [StringLength(32)]
        public string MATERIALSCODE { get; set; }

        [StringLength(32)]
        public string BUSINESSCODE { get; set; }

        [StringLength(32)]
        public string AREACODE { get; set; }

        [StringLength(16)]
        public string LOCATIONCODE { get; set; }
    }
}
