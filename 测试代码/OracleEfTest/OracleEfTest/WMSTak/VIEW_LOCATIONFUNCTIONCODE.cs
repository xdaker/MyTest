namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.VIEW_LOCATIONFUNCTIONCODE")]
    public partial class VIEW_LOCATIONFUNCTIONCODE
    {
        [Key]
        [StringLength(36)]
        public string LOCATIONID { get; set; }

        [StringLength(16)]
        public string LOCATIONFUNCTIONCODE { get; set; }
    }
}
