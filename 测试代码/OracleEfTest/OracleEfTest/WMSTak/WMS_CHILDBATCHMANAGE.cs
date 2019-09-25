namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_CHILDBATCHMANAGE")]
    public partial class WMS_CHILDBATCHMANAGE
    {
        [Key]
        [StringLength(30)]
        public string BATCH { get; set; }

        public int? CHILDBATCH { get; set; }

        public DateTime? CHILDBATCHDATE { get; set; }
    }
}
