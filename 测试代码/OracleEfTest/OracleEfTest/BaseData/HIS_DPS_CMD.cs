namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.HIS_DPS_CMD")]
    public partial class HIS_DPS_CMD
    {
        [Key]
        public decimal DPS_CMD_ID { get; set; }

        [StringLength(64)]
        public string LOCATE_CODE { get; set; }

        [StringLength(20)]
        public string LPN { get; set; }

        [StringLength(10)]
        public string DPS_OPE_TYPE { get; set; }

        [StringLength(50)]
        public string DPS_COLOR { get; set; }

        public short? DPS_QTY { get; set; }

        [StringLength(2)]
        public string DPS_CMD_ST { get; set; }

        public DateTime? CREA_TIME { get; set; }

        public DateTime? UPDATE_TIME { get; set; }

        [StringLength(200)]
        public string COMMENTS { get; set; }

        public decimal? TASKDTL { get; set; }
    }
}
