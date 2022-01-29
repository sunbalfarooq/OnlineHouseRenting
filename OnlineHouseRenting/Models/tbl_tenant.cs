namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_tenant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_tenant()
        {
            tbl_order = new HashSet<tbl_order>();
        }

        [Key]
        public int TENANT_ID { get; set; }

        [StringLength(50)]
        public string TENANT_CONTACT { get; set; }

        [StringLength(50)]
        public string TENANT_EMAIL { get; set; }

        [StringLength(50)]
        public string TENANT_PASSWORD { get; set; }

        [StringLength(50)]
        public string TENANT_ADDRESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order> tbl_order { get; set; }
    }
}
