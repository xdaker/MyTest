namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_FORMATTRIBUTEVALUE")]
    public partial class BASE_FORMATTRIBUTEVALUE
    {
        [Key]
        [StringLength(50)]
        public string ATTRIBUTEVALUEID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string OBJECTID { get; set; }

        [StringLength(1000)]
        public string OBJECTPARAMETERJSON { get; set; }
    }
}
