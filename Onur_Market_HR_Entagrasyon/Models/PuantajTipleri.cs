using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class PuantajTipleri
    {
        public int PuantajTipiId { get; set; }
        public string KisaKodu { get; set; }
        public string Adi { get; set; }
        public int? Tipi { get; set; }
        public string DigerPuantajTipleri { get; set; }
        public string EsitPuantaj { get; set; }
        public long? Ilk1 { get; set; }
        public long? Son1 { get; set; }
        public long? Toplam1 { get; set; }
        public long? Ilk2 { get; set; }
        public long? Son2 { get; set; }
        public long? Toplam2 { get; set; }
        public long? Ilk3 { get; set; }
        public long? Son3 { get; set; }
        public long? Toplam3 { get; set; }
        public long? MaxLimit { get; set; }
        public int? AylikPuantaj { get; set; }
        public bool? OnayGerekli { get; set; }
        public int? Carpan { get; set; }
        public bool? AktifMi { get; set; }
        public int? SirketId { get; set; }
    }
}
