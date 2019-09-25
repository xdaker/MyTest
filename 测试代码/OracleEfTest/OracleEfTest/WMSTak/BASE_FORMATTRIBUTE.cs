namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_FORMATTRIBUTE")]
    public partial class BASE_FORMATTRIBUTE
    {
        [Key]
        [StringLength(50)]
        public string FORMATTRIBUTEID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string PROPERTYNAME { get; set; }

        [StringLength(50)]
        public string CONTROLID { get; set; }

        [StringLength(50)]
        public string CONTROLTYPE { get; set; }

        [StringLength(50)]
        public string CONTROLSTYLE { get; set; }

        [StringLength(50)]
        public string CONTROLVALIDATOR { get; set; }

        public int? IMPORTLENGTH { get; set; }

        [StringLength(50)]
        public string DEFAULTVLAUE { get; set; }

        [StringLength(1000)]
        public string ATTRIBUTESPROPERTY { get; set; }

        public int? DATASOURCETYPE { get; set; }

        [StringLength(1000)]
        public string DATASOURCE { get; set; }

        [StringLength(50)]
        public string CONTROLCOLSPAN { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

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
