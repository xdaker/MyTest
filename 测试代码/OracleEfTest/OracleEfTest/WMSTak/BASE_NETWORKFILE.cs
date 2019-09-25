namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_NETWORKFILE")]
    public partial class BASE_NETWORKFILE
    {
        [Key]
        [StringLength(50)]
        public string NETWORKFILEID { get; set; }

        [StringLength(50)]
        public string FOLDERID { get; set; }

        [StringLength(200)]
        public string FILENAME { get; set; }

        [StringLength(200)]
        public string FILEPATH { get; set; }

        [StringLength(50)]
        public string FILESIZE { get; set; }

        [StringLength(50)]
        public string FILEEXTENSIONS { get; set; }

        [StringLength(50)]
        public string FILETYPE { get; set; }

        [StringLength(50)]
        public string ICON { get; set; }

        public int? SHARING { get; set; }

        [StringLength(50)]
        public string SHARINGFOLDERID { get; set; }

        public DateTime? SHARINGCREATEDATE { get; set; }

        public DateTime? SHARINGENDDATE { get; set; }

        public int? ENABLED { get; set; }

        public int? SORTCODE { get; set; }

        public int? DELETEMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }
    }
}
