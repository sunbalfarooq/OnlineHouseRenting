namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_contact
    {
        [Key]
        public int CONTACT_ID { get; set; }

        [StringLength(50)]
        public string CONTACT_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CONTACT_EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string CONTACT_MESSAGE { get; set; }
    }
}
