using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class AylikPuantajTablosu
    {
        public int AylikPuantajId { get; set; }
        public string Adi { get; set; }
        public string KisaKod { get; set; }
        public bool Ssk { get; set; }
        public bool Toplam { get; set; }
        public bool Calisma { get; set; }
        public int? SirketId { get; set; }
        public int? IzinId { get; set; }
        public bool? AktifMi { get; set; }
        public int? Carpan { get; set; }
        public int? ArtiEksi { get; set; }
    }
}
