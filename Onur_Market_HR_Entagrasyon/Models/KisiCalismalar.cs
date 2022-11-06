using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiCalismalar
    {
        public int KisiIzinId { get; set; }
        public int? KisiId { get; set; }
        public int? IzinId { get; set; }
        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }
        public string Aciklama { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public int? SirketId { get; set; }
        public bool? TatillerPass { get; set; }
    }
}
