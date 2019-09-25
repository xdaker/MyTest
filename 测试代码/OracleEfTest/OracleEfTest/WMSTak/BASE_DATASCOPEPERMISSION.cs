namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_DATASCOPEPERMISSION")]
    public partial class BASE_DATASCOPEPERMISSION
    {
        [Key]
        [StringLength(50)]
        public string DATASCOPEPERMISSIONID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string OBJECTID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string RESOURCEID { get; set; }

        [StringLength(1024)]
        public string CONDITION { get; set; }

        [StringLength(1024)]
        public string CONDITIONJSON { get; set; }

        [StringLength(50)]
        public string SCOPETYPE { get; set; }

        public int? SORTCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }
    }
}
