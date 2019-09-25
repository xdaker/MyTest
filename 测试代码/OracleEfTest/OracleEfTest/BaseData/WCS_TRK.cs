namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WCS_TRK")]
    public partial class WCS_TRK
    {
        [Key]
        public decimal TRK_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LPN_NO { get; set; }

        [StringLength(50)]
        public string DVC_NO { get; set; }

        [StringLength(2)]
        public string TRK_PRTY { get; set; }

        [StringLength(20)]
        public string FRM_POS { get; set; }

        [StringLength(20)]
        public string TO_POS { get; set; }

        [StringLength(20)]
        public string CUR_POS { get; set; }

        [StringLength(20)]
        public string NEXT_POS { get; set; }

        public byte? TRK_ST { get; set; }

        [StringLength(20)]
        public string TRK_TYPE { get; set; }

        public decimal? CAL_WEIGHT { get; set; }

        public decimal? ACT_WEIGHT { get; set; }

        public long? SOURCE_ID { get; set; }

        [StringLength(20)]
        public string SOURCE_NO { get; set; }

        [StringLength(64)]
        public string SKU_NO { get; set; }

        [StringLength(20)]
        public string ZONE_NO { get; set; }

        public decimal? TASK_ID { get; set; }

        [StringLength(400)]
        public string COMMENTS { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal? QTY { get; set; }
    }
}
