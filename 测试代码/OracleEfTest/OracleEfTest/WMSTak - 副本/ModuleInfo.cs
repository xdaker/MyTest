namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.ModuleInfo")]
    public partial class ModuleInfo
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        public string Version { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string AssemblyFileName { get; set; }

        public bool? IsMain { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
