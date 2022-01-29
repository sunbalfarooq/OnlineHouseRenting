namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_house_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_house_detail()
        {
            tbl_order_detail = new HashSet<tbl_order_detail>();
            tbl_order = new HashSet<tbl_order>();
        }

        [Key]
        public int HOUSE_DETAIL_ID { get; set; }
        public int BATH_ROOMS { get; set; } 
        public int BED_ROOMS { get; set; }
        public int PRICE_RANGE { get; set; }

        [StringLength(50)]
        public string HOUSE_ORDER { get; set; }
        
        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string HOUSE_PIC { get; set; }

        [StringLength(50)]
        public string HOUSE_DESCRIPTION { get; set; }

        [StringLength(50)]
        public string HOUSE_STATUS { get; set; }

        public int? HOUSE_CATEGORY_FID { get; set; }

        public virtual tbl_category tbl_category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order_detail> tbl_order_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order> tbl_order { get; set; }
    }
}
