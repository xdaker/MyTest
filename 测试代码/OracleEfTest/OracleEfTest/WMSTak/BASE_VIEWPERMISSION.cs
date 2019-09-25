namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_VIEWPERMISSION")]
    public partial class BASE_VIEWPERMISSION
    {
        [Key]
        [StringLength(50)]
        public string VIEWPERMISSIONID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string OBJECTID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [Required]
        [StringLength(50)]
        public string VIEWID { get; set; }

        public int? SORTCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }
    }
}
