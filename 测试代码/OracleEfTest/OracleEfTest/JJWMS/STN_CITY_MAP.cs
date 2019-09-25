namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.STN_CITY_MAP")]
    public partial class STN_CITY_MAP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string STN_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CITY { get; set; }

        [StringLength(200)]
        public string CITY_NAME { get; set; }

        [StringLength(200)]
        public string COMMENTS { get; set; }

        public DateTime? DIS_TIME { get; set; }
    }
}
