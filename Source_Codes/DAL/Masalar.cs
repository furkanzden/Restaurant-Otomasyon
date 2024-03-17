namespace FurkanOzden_221103052.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masalar")]
    public partial class Masalar
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }
    }
}
