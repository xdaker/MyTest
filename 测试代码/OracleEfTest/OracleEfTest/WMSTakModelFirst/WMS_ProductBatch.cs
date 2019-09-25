namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_ProductBatch")]
    public partial class WMS_ProductBatch
    {
        [Key]
        [StringLength(30)]
        public string Batch { get; set; }

        public int productBatch { get; set; }

        
        public DateTime ChildBatchDate { get; set; }
    }
}
