namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_CODERULEDETAIL")]
    public partial class BASE_CODERULEDETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODERULEDETAILID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODERULEID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SORTCODE { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string CONSTED { get; set; }

        public int? AUTORESET { get; set; }

        public int? FIXLENGTH { get; set; }

        [StringLength(50)]
        public string FORMATSTR { get; set; }

        public int? STEPVALUE { get; set; }

        public int? INITVALUE { get; set; }

        public int? FLENGTH { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string FTYPE { get; set; }

        public int? ENABLED { get; set; }

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
