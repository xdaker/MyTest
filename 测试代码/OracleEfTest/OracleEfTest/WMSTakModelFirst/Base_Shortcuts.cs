namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.Base_Shortcuts")]
    public partial class Base_Shortcuts
    {
        [Key]
        [StringLength(50)]
        public string ShortcutsId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }
    }
}
