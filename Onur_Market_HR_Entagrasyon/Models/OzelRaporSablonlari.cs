using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class OzelRaporSablonlari
    {
        public int OzelRaporSablonId { get; set; }
        public int? OzelRaporId { get; set; }
        public string OzelRaporSablonAdi { get; set; }
        public string RaporOzellikleri { get; set; }
        public string GosterilecekRaporAlanlari { get; set; }
        public string Filtre { get; set; }
        public string Siralama { get; set; }
        public string YetkiliKullanicilar { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public bool? AktifMi { get; set; }
        public int? SirketId { get; set; }
    }
}
