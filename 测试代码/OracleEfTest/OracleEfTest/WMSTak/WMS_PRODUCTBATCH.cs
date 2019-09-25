namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_PRODUCTBATCH")]
    public partial class WMS_PRODUCTBATCH
    {
        [Key]
        [StringLength(30)]
        public string BATCH { get; set; }

        public int PRODUCTBATCH { get; set; }

        public DateTime CHILDBATCHDATE { get; set; }
    }
}
