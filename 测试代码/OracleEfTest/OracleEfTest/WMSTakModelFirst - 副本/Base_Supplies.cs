namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.Base_Supplies")]
    public partial class Base_Supplies
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SupplierId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Telephone { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Fax { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string AccountsMethod { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string LinkMan { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string LeadingOfficialId { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Address { get; set; }
    }
}
