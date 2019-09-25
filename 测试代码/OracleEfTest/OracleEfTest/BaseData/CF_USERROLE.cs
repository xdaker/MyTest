namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.CF_USERROLE")]
    public partial class CF_USERROLE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERROLE_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string USER_NO { get; set; }

        [Required]
        [StringLength(50)]
        public string ROLE_NO { get; set; }

        public bool IS_ACTIVE { get; set; }

        [StringLength(20)]
        public string ADD_WHO { get; set; }

        public DateTime? ADD_TIME { get; set; }

        [StringLength(20)]
        public string EDIT_WHO { get; set; }

        public DateTime? EDIT_TIME { get; set; }

        [StringLength(200)]
        public string COMMENTS { get; set; }

        public int USER_ID { get; set; }

        public int ROLE_ID { get; set; }

        [StringLength(20)]
        public string WH_NO { get; set; }
    }
}
