namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_admin
    {
        [Key]
        public int ADMIN_ID { get; set; }

        [StringLength(50)]
        public string ADMIN_CONTACT { get; set; }

        [Required]
        [StringLength(50)]
        public string ADMIN_EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string ADMIN_PASSWORD { get; set; }

        [StringLength(50)]
        public string ADMIN_ADDRESS { get; set; }
    }
}
