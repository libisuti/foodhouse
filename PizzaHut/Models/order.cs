namespace PizzaHut.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order")]
    public partial class order
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string deliveryaddress { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string deliveryname { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string deliveryphone { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string deliveryemail { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime updated_at { get; set; }
    }
}
