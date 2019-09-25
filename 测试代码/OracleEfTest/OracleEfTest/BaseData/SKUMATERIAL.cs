namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SKUMATERIAL")]
    public partial class SKUMATERIAL
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string QRCODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string SKUNO { get; set; }

        [StringLength(128)]
        public string STYLE { get; set; }

        [StringLength(1024)]
        public string DESCRIPTION { get; set; }

        [StringLength(1024)]
        public string DESCRIPTION2 { get; set; }

        [StringLength(1024)]
        public string SHORTNAME { get; set; }

        public decimal? COMPANYSYSNO { get; set; }

        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        public decimal? ISFREEZED { get; set; }

        public decimal? ISACTIVE { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        [StringLength(50)]
        public string EQUNR { get; set; }

        [StringLength(50)]
        public string INBDT { get; set; }

        [StringLength(50)]
        public string ANSDT { get; set; }

        [StringLength(50)]
        public string AENAM { get; set; }

        [StringLength(50)]
        public string AEDAT { get; set; }

        [StringLength(50)]
        public string B_WERK { get; set; }

        [StringLength(50)]
        public string B_LAGER { get; set; }

        [StringLength(200)]
        public string LGOBE { get; set; }

        [StringLength(50)]
        public string SOBKZ { get; set; }

        [StringLength(50)]
        public string KUNNR { get; set; }

        [StringLength(50)]
        public string SERGE { get; set; }

        [StringLength(50)]
        public string SKUCODE { get; set; }
    }
}
