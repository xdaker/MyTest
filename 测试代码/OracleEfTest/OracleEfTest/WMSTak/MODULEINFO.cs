namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.MODULEINFO")]
    public partial class MODULEINFO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string VERSION { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string ASSEMBLYFILENAME { get; set; }

        public bool? ISMAIN { get; set; }

        public int? OPTIMISTICLOCKFIELD { get; set; }
    }
}
