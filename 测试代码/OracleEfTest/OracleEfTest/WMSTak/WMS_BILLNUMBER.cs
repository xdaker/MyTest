namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_BILLNUMBER")]
    public partial class WMS_BILLNUMBER
    {
        [Key]
        [StringLength(100)]
        public string BILLNAME { get; set; }

        public int? BILLNUMBER { get; set; }

        public DateTime? BILLDATETIME { get; set; }
    }
}
