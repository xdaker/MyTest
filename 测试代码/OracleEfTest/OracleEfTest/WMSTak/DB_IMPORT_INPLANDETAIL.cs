namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.DB_IMPORT_INPLANDETAIL")]
    public partial class DB_IMPORT_INPLANDETAIL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string CONTAINERCODE { get; set; }

        [StringLength(50)]
        public string SUPPLIERCODE { get; set; }

        [StringLength(50)]
        public string SUPPLIERNAME { get; set; }

        [StringLength(50)]
        public string MATERIALSICODE { get; set; }

        [StringLength(50)]
        public string MATERIALSINAME { get; set; }

        public int? INQUANTITY { get; set; }

        public int? SUMINQUANTITY { get; set; }

        public int? SUMOUTQUANTITY { get; set; }

        public int? SUMQUANTITY { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }
    }
}
