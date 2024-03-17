namespace FurkanOzden_221103052.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Detaylar")]
    public partial class Detaylar
    {
        public int ID { get; set; }

        public int SipID { get; set; }

        public int UrID { get; set; }

        public int Adet { get; set; }

        public decimal Fiyat { get; set; }

        public decimal AraToplam { get; set; }
    }
}
