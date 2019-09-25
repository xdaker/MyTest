namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_NETWORKFOLDER")]
    public partial class BASE_NETWORKFOLDER
    {
        [Key]
        [StringLength(50)]
        public string FOLDERID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(200)]
        public string FOLDERNAME { get; set; }

        public int? ISPUBLIC { get; set; }

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

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }
    }
}
