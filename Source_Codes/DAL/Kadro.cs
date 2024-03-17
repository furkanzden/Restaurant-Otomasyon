namespace FurkanOzden_221103052.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kadro")]
    public partial class Kadro
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Parola { get; set; }

        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefon { get; set; }

        public int? Rol { get; set; }
        public int IGiris { get; set; }

    }
}
