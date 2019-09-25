namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_SYSLOG")]
    public partial class BASE_SYSLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BASE_SYSLOG()
        {
            BASE_SYSLOGDETAIL = new HashSet<BASE_SYSLOGDETAIL>();
        }

        [Key]
        [StringLength(50)]
        public string SYSLOGID { get; set; }

        [StringLength(50)]
        public string OBJECTID { get; set; }

        [StringLength(50)]
        public string LOGTYPE { get; set; }

        [StringLength(50)]
        public string IPADDRESS { get; set; }

        [StringLength(200)]
        public string IPADDRESSNAME { get; set; }

        [StringLength(50)]
        public string COMPANYID { get; set; }

        [StringLength(50)]
        public string DEPARTMENTID { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASE_SYSLOGDETAIL> BASE_SYSLOGDETAIL { get; set; }
    }
}
