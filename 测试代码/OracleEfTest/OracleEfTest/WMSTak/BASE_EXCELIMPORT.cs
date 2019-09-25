namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_EXCELIMPORT")]
    public partial class BASE_EXCELIMPORT
    {
        [Key]
        [StringLength(50)]
        public string IMPORTID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string IMPORTNAME { get; set; }

        [StringLength(50)]
        public string IMPORTTABLE { get; set; }

        [StringLength(50)]
        public string IMPORTTABLENAME { get; set; }

        [StringLength(200)]
        public string IMPORTFILENAME { get; set; }

        public int? ERRORHANDING { get; set; }

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

        [StringLength(50)]
        public string MODULEID { get; set; }
    }
}
