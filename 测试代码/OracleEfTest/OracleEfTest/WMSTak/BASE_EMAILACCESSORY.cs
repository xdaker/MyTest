namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_EMAILACCESSORY")]
    public partial class BASE_EMAILACCESSORY
    {
        [Key]
        [StringLength(50)]
        public string EMAILACCESSORYID { get; set; }

        [StringLength(50)]
        public string EMAILID { get; set; }

        [StringLength(50)]
        public string FILENAME { get; set; }

        [StringLength(200)]
        public string FILEPATH { get; set; }

        [StringLength(50)]
        public string FILESIZE { get; set; }

        [StringLength(50)]
        public string FILETYPE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public virtual BASE_EMAIL BASE_EMAIL { get; set; }
    }
}
