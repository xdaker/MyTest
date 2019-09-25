namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_EMAIL")]
    public partial class BASE_EMAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BASE_EMAIL()
        {
            BASE_EMAILACCESSORY = new HashSet<BASE_EMAILACCESSORY>();
            BASE_EMAILADDRESSEE = new HashSet<BASE_EMAILADDRESSEE>();
        }

        [Key]
        [StringLength(50)]
        public string EMAILID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(200)]
        public string THEME { get; set; }

        [StringLength(50)]
        public string THEMECOLOUR { get; set; }

        [StringLength(1024)]
        public string CONTENT { get; set; }

        [StringLength(50)]
        public string ADDRESSER { get; set; }

        public DateTime? SENDDATE { get; set; }

        public int? ISACCESSORY { get; set; }

        public int? PRIORITY { get; set; }

        public int? RECEIPT { get; set; }

        public int? ISDELAYED { get; set; }

        public DateTime? DELAYEDTIME { get; set; }

        public int? STATE { get; set; }

        public int? DELETEMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASE_EMAILACCESSORY> BASE_EMAILACCESSORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASE_EMAILADDRESSEE> BASE_EMAILADDRESSEE { get; set; }
    }
}
