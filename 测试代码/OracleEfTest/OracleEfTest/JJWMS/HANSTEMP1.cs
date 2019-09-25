namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.HANSTEMP1")]
    public partial class HANSTEMP1
    {
        [Key]
        [Column(Order = 0)]
        public decimal SKUCODE { get; set; }

        public decimal? WAREHOUSESYSCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string LOCATIONCODE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal QTY { get; set; }
    }
}
