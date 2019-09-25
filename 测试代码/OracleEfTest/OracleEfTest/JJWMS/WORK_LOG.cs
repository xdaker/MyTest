namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WORK_LOG")]
    public partial class WORK_LOG
    {
        [Key]
        public decimal WORK_ID { get; set; }

        [StringLength(100)]
        public string WORK_NAME { get; set; }

        [StringLength(10)]
        public string LPN_NO { get; set; }

        [StringLength(20)]
        public string WORK_CODE { get; set; }

        [StringLength(300)]
        public string WORK_MSG { get; set; }

        [StringLength(100)]
        public string WORK_PROC { get; set; }

        public DateTime CREA_TIME { get; set; }

        public decimal? WORK_SEC { get; set; }

        [StringLength(20)]
        public string WORK_PER_NO { get; set; }

        [StringLength(20)]
        public string WORK_PER_NAME { get; set; }
    }
}
