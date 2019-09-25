namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.CF_ROLE")]
    public partial class CF_ROLE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROLE_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string ROLE_NO { get; set; }

        [Required]
        [StringLength(50)]
        public string ROLE_NAME { get; set; }

        [StringLength(100)]
        public string ROLE_DESC { get; set; }

        public int IS_ACTIVE { get; set; }

        [StringLength(20)]
        public string ADD_WHO { get; set; }

        public DateTime? ADD_TIME { get; set; }

        [StringLength(20)]
        public string EDIT_WHO { get; set; }

        public DateTime? EDIT_TIME { get; set; }

        [StringLength(200)]
        public string COMMENTS { get; set; }

        [StringLength(20)]
        public string WH_NO { get; set; }
    }
}
