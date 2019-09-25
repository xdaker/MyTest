namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CWUSER.UserTable")]
    public partial class UserTable
    {
        [StringLength(1024)]
        public string Id { get; set; }
    }
}
