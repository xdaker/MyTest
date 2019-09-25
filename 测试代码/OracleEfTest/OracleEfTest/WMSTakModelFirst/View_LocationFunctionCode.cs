namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.View_LocationFunctionCode")]
    public partial class View_LocationFunctionCode
    {
        [Key]
        [StringLength(36)]
        public string LocationId { get; set; }

        [StringLength(16)]
        public string LocationFunctionCode { get; set; }
    }
}
