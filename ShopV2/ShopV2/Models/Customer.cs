namespace ShopV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {


        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cusFullName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string password { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string cusPhone { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string cusMail { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string cusAddress { get; set; }
    }
}
