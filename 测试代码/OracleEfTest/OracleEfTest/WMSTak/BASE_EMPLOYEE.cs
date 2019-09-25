namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_EMPLOYEE")]
    public partial class BASE_EMPLOYEE
    {
        [Key]
        [StringLength(50)]
        public string EMPLOYEEID { get; set; }

        [StringLength(50)]
        public string USERID { get; set; }

        [StringLength(50)]
        public string PHOTOGRAPH { get; set; }

        [StringLength(50)]
        public string IDCARD { get; set; }

        public int? AGE { get; set; }

        [StringLength(50)]
        public string BANKCODE { get; set; }

        [StringLength(50)]
        public string OFFICECORNET { get; set; }

        [StringLength(50)]
        public string OFFICEPHONE { get; set; }

        [StringLength(50)]
        public string OFFICEZIPCODE { get; set; }

        [StringLength(200)]
        public string OFFICEADDRESS { get; set; }

        [StringLength(50)]
        public string OFFICEFAX { get; set; }

        [StringLength(50)]
        public string EDUCATION { get; set; }

        [StringLength(50)]
        public string SCHOOL { get; set; }

        public DateTime? GRADUATIONDATE { get; set; }

        [StringLength(50)]
        public string MAJOR { get; set; }

        [StringLength(50)]
        public string DEGREE { get; set; }

        public DateTime? WORKINGDATE { get; set; }

        [StringLength(50)]
        public string HOMEZIPCODE { get; set; }

        [StringLength(200)]
        public string HOMEADDRESS { get; set; }

        [StringLength(50)]
        public string HOMEPHONE { get; set; }

        [StringLength(50)]
        public string HOMEFAX { get; set; }

        [StringLength(50)]
        public string PROVINCE { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string AREA { get; set; }

        [StringLength(50)]
        public string NATIVEPLACE { get; set; }

        [StringLength(50)]
        public string PARTY { get; set; }

        [StringLength(50)]
        public string NATION { get; set; }

        [StringLength(50)]
        public string NATIONALITY { get; set; }

        [StringLength(50)]
        public string DUTY { get; set; }

        [StringLength(50)]
        public string WORKINGPROPERTY { get; set; }

        [StringLength(50)]
        public string COMPETENCY { get; set; }

        [StringLength(50)]
        public string EMERGENCYCONTACT { get; set; }

        public int? ISDIMISSION { get; set; }

        public DateTime? DIMISSIONDATE { get; set; }

        [StringLength(200)]
        public string DIMISSIONCAUSE { get; set; }

        [StringLength(50)]
        public string DIMISSIONWHITHER { get; set; }
    }
}
