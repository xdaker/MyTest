namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_INTERFACEMANAGE")]
    public partial class BASE_INTERFACEMANAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BASE_INTERFACEMANAGE()
        {
            BASE_INTERFACEMANAGEPARAMETER = new HashSet<BASE_INTERFACEMANAGEPARAMETER>();
        }

        [Key]
        [StringLength(50)]
        public string INTERFACEID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string ACTION { get; set; }

        [StringLength(1000)]
        public string CONSTRAINTS { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASE_INTERFACEMANAGEPARAMETER> BASE_INTERFACEMANAGEPARAMETER { get; set; }
    }
}
