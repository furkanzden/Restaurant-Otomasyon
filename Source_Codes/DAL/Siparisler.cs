namespace FurkanOzden_221103052.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Siparisler")]
    public partial class Siparisler
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Tarih { get; set; }

        [Required]
        [StringLength(50)]
        public string Saat { get; set; }

        public string MasaAd { get; set; }

        public string GarsonAd { get; set; }

        [Required]
        public int Durum { get; set; }

        [Required]
        [StringLength(50)]
        public string Tur { get; set; }

        public decimal Toplam { get; set; }

        public decimal Alınan { get; set; }

        public decimal changed { get; set; }
    }
}
