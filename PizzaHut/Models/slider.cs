namespace PizzaHut.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("slider")]
    public partial class slider
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string url { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string position { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string img { get; set; }

        public int? orders { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime created_at { get; set; }

        public int? created_by { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime updated_at { get; set; }

        public int? updated_by { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status { get; set; }
    }
}
