namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.DB_Import_InPlanDetail")]
    public partial class DB_Import_InPlanDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string ContainerCode { get; set; }

        [StringLength(50)]
        public string SupplierCode { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        [StringLength(50)]
        public string MaterialsICode { get; set; }

        [StringLength(50)]
        public string MaterialsIName { get; set; }

        public int? InQuantity { get; set; }

        public int? SumInQuantity { get; set; }

        public int? SumOutQuantity { get; set; }

        public int? SumQuantity { get; set; }

        public string Remark { get; set; }
    }
}
