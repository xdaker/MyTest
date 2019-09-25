namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_INTERFACEMANAGEPARAMETER")]
    public partial class BASE_INTERFACEMANAGEPARAMETER
    {
        [Key]
        [StringLength(50)]
        public string INTERFACEPARAMETERID { get; set; }

        [StringLength(50)]
        public string INTERFACEID { get; set; }

        [StringLength(50)]
        public string FIELD { get; set; }

        [StringLength(200)]
        public string FIELDMEMO { get; set; }

        [StringLength(50)]
        public string FIELDTYPE { get; set; }

        public int? FIELDMAXLENGTH { get; set; }

        public int? ALLOWNULL { get; set; }

        public int? ENABLED { get; set; }

        public int? SORTCODE { get; set; }

        public int? DELETEMARK { get; set; }

        public virtual BASE_INTERFACEMANAGE BASE_INTERFACEMANAGE { get; set; }
    }
}
