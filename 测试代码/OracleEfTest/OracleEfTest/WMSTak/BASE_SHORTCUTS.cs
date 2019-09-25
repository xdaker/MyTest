namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_SHORTCUTS")]
    public partial class BASE_SHORTCUTS
    {
        [Key]
        [StringLength(50)]
        public string SHORTCUTSID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }
    }
}
