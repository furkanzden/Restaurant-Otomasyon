namespace FurkanOzden_221103052.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urunler")]
    public partial class Urunler
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        public decimal? Fiyat { get; set; }

        public int? KategoriID { get; set; }

        [Column(TypeName = "text")]
        public string Resim { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }
    }
}
