namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SP_DIS_SET")]
    public partial class SP_DIS_SET
    {
        public decimal? DIS_ID { get; set; }

        [Key]
        [StringLength(40)]
        public string SP_AREA { get; set; }
    }
}
