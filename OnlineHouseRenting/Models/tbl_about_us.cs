namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_about_us
    {
        [Key]
        public int COMPANY_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_LOGO { get; set; }

        [StringLength(10)]
        public string COMPANY_CONTACT { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_EMAIL { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_ADDRESS { get; set; }
    }
}
