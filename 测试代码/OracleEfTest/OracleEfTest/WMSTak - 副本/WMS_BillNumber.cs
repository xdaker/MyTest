namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_BillNumber")]
    public partial class WMS_BillNumber
    {
        [Key]
        [StringLength(100)]
        public string BillName { get; set; }

        public int? BillNumber { get; set; }

        public DateTime? BillDateTime { get; set; }
    }
}
