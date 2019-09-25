namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.V_MENU_AUTH_PARENT")]
    public partial class V_MENU_AUTH_PARENT
    {
        [StringLength(64)]
        public string CODE { get; set; }

        [StringLength(128)]
        public string ACTNAME { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int P_MASTERKEY { get; set; }

        [StringLength(64)]
        public string PARENTCODE { get; set; }
    }
}
