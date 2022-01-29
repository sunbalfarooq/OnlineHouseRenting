namespace OnlineHouseRenting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_order_detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDER_DETAIL_ID { get; set; }

        public DateTime? START_DATE_TIME { get; set; }

        public DateTime? END_DATE_TIME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HOUSE_DETAIL_FID { get; set; }

        public int ORDER_FID { get; set; }

        public virtual tbl_house_detail tbl_house_detail { get; set; }

        public virtual tbl_order tbl_order { get; set; }
    }
}
