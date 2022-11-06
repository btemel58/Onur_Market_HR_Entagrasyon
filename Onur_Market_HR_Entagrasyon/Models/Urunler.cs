using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklamasi { get; set; }
        public int? UrunKategoriId { get; set; }
        public decimal? BayiSatisFiyati { get; set; }
        public decimal? MusteriSatisFiyati { get; set; }
        public int? StokAdet { get; set; }
        public int? UrunParaBirimiId { get; set; }
        public bool? AktifMi { get; set; }
        public byte[] Foto { get; set; }
    }
}
