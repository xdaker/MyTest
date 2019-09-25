namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_BUTTONPERMISSION")]
    public partial class BASE_BUTTONPERMISSION
    {
        [Key]
        [StringLength(50)]
        public string BUTTONPERMISSIONID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string OBJECTID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [Required]
        [StringLength(50)]
        public string MODULEBUTTONID { get; set; }

        public int? SORTCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }
    }
}
