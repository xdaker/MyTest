namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.CF_PRIVILEGE")]
    public partial class CF_PRIVILEGE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int P_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string P_MASTER { get; set; }

        public int P_MASTERKEY { get; set; }

        [StringLength(100)]
        public string P_ACCESS { get; set; }

        public int P_ACCESSKEY { get; set; }

        [Required]
        [StringLength(50)]
        public string P_OPERATION { get; set; }

        [StringLength(20)]
        public string ADD_WHO { get; set; }

        public DateTime? ADD_TIME { get; set; }

        [StringLength(20)]
        public string EDIT_WHO { get; set; }

        public DateTime? EDIT_TIME { get; set; }

        [StringLength(200)]
        public string COMMENTS { get; set; }
    }
}
