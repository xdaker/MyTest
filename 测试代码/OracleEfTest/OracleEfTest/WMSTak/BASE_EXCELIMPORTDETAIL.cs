namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_EXCELIMPORTDETAIL")]
    public partial class BASE_EXCELIMPORTDETAIL
    {
        [Key]
        [StringLength(50)]
        public string IMPORTDETAILID { get; set; }

        [StringLength(50)]
        public string IMPORTID { get; set; }

        [StringLength(50)]
        public string COLUMNNAME { get; set; }

        [StringLength(50)]
        public string FIELDNAME { get; set; }

        [StringLength(200)]
        public string FOREIGNTABLE { get; set; }

        [StringLength(200)]
        public string BACKFIELD { get; set; }

        [StringLength(200)]
        public string COMPAREFIELD { get; set; }

        [StringLength(200)]
        public string ATTACHCONDITION { get; set; }

        public int? DATATYPE { get; set; }

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
        public string FIELDREMARK { get; set; }
    }
}
