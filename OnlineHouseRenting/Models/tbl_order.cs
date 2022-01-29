namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_order()
        {
            tbl_order_detail = new HashSet<tbl_order_detail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HOUSE_ORDER_ID { get; set; }

        [StringLength(50)]
        public string HOUSE_ORDER_STATUS { get; set; }

        public DateTime? ORDER_DATE_TIME { get; set; }

        public int TENANT_FID { get; set; }

        public int HOUSE_DETAIL_FID { get; set; }

        public virtual tbl_house_detail tbl_house_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order_detail> tbl_order_detail { get; set; }

        public virtual tbl_tenant tbl_tenant { get; set; }
    }
}
