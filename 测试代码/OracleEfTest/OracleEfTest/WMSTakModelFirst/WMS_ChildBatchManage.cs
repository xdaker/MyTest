namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_ChildBatchManage")]
    public partial class WMS_ChildBatchManage
    {
        [Key]
        [StringLength(30)]
        public string Batch { get; set; }

        public int? ChildBatch { get; set; }

        public DateTime? ChildBatchDate { get; set; }
    }
}
