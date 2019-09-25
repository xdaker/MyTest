namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_JXD")]
    public partial class WMS_JXD
    {
        [Key]
        [StringLength(100)]
        public string JXNO { get; set; }

        public int? SQNO { get; set; }

        public DateTime? STDT { get; set; }

        public DateTime? ENDT { get; set; }

        [StringLength(100)]
        public string CWOC { get; set; }

        [StringLength(100)]
        public string CKGL { get; set; }

        [StringLength(100)]
        public string PSQY { get; set; }

        [StringLength(100)]
        public string OPRO { get; set; }

        public int? JXFS { get; set; }

        [StringLength(100)]
        public string PDNO { get; set; }

        public int? OPNO { get; set; }

        public DateTime? JX_DATE { get; set; }
    }
}
