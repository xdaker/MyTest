namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SKU")]
    public partial class SKU
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string CODE { get; set; }

        [StringLength(64)]
        public string CODE2 { get; set; }

        [StringLength(64)]
        public string CODE3 { get; set; }

        [StringLength(128)]
        public string PN { get; set; }

        [StringLength(128)]
        public string STYLE { get; set; }

        [StringLength(1024)]
        public string DESCRIPTION { get; set; }

        [StringLength(1024)]
        public string DESCRIPTION2 { get; set; }

        [StringLength(1024)]
        public string SHORTNAME { get; set; }

        public decimal? COMPANYSYSNO { get; set; }

        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        public decimal? CARTONTYPESYSNO { get; set; }

        [StringLength(32)]
        public string CARTONTYPECODE { get; set; }

        [StringLength(32)]
        public string ACTSIZE { get; set; }

        [StringLength(32)]
        public string COLOR { get; set; }

        [StringLength(32)]
        public string SEASON { get; set; }

        public decimal? SHELFLIFE { get; set; }

        public decimal? SHELFLIFEPRE { get; set; }

        public decimal? SHELFLIFERATIO { get; set; }

        [StringLength(512)]
        public string SKUTYPE { get; set; }

        [StringLength(1024)]
        public string SKUTYPEDESC { get; set; }

        [StringLength(512)]
        public string SKUCLASS { get; set; }

        [StringLength(1024)]
        public string SKUCLASSDESC { get; set; }

        public decimal? PACKSYSNO { get; set; }

        [StringLength(64)]
        public string PACKCODE { get; set; }

        public decimal? LENGTH { get; set; }

        public decimal? WIDTH { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? CUBE { get; set; }

        public decimal? NETWEIGHT { get; set; }

        public decimal? TARE { get; set; }

        public decimal? MOVEMENTTYPE { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? COST { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ISLOTCONTROLLED { get; set; }

        public decimal? SERIANUMBERTRACKING { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal PNFLAG { get; set; }

        public decimal? ACTIVE { get; set; }

        public decimal? LOTATTRTEMPLATESYSNO { get; set; }

        [StringLength(32)]
        public string LOTATTRTEMPLATECODE { get; set; }

        [StringLength(32)]
        public string BARCODETEMPLATECODE { get; set; }

        public decimal? ENABLEFLAG { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal ISCOMMINGLELOT { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ISFRAGILE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ISPRIVATE { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ISLIQUID { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ISINFLAMMABLESANDEXPLOSIVES { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ISSERVICEPRODUCTS { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal? GROSSWEIGHT { get; set; }

        [StringLength(64)]
        public string BRAND { get; set; }

        [StringLength(500)]
        public string TAG { get; set; }

        public decimal? SIZETYPE { get; set; }

        public decimal? ISENERGYSUBSIDIES { get; set; }

        public decimal? ISMANDATORYSNACQUISITION { get; set; }

        public decimal? PACKQTY { get; set; }

        [StringLength(256)]
        public string BUSINESSFLAG { get; set; }

        public decimal? ISREVIEWPHYSICALINFO { get; set; }

        public decimal? ISICSONNUMBERFLAG { get; set; }

        public decimal? ISWQFREENUMBERFLAG { get; set; }

        public decimal? ALERTQTY { get; set; }
    }
}
