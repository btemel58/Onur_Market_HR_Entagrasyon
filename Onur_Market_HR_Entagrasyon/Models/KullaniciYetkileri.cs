using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KullaniciYetkileri
    {
        public int YetkiId { get; set; }
        public string YetkiAdi { get; set; }
        public string Aciklama { get; set; }
        public int? Statu { get; set; }
        public bool? AktifMi { get; set; }
        public int? CanliIzleme { get; set; }
        public int? Kisiler { get; set; }
        public int? GecisYetkileri { get; set; }
        public int? Raporlar { get; set; }
        public int? Tanimlamalar { get; set; }
        public int? Ayarlar { get; set; }
        public int? ZiyaretciTakip { get; set; }
        public int? Yemekhane { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegistirilmeZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public int? SirketId { get; set; }
        public string Filtre { get; set; }
        public int? BakiyeliSatis { get; set; }
        public int? Dashboard { get; set; }
    }
}
