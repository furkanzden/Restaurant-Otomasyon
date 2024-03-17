namespace FurkanOzden_221103052.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Roller")]
    public partial class Roller
    {


        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }
        public int Kategori { get; set; }
        public int Masa { get; set; }
        public int Urun { get; set; }
        public int Mutfak { get; set; }
        public int Pos { get; set; }
        public int Rol { get; set; }
        public int Kadro { get; set; }


    }
}
