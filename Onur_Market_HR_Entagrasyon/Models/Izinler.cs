using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Izinler
    {
        public int IzinId { get; set; }
        public string Adi { get; set; }
        public string KisaKod { get; set; }
        public int? Tip { get; set; }
        public bool? AylikTablo { get; set; }
        public int? AylikPuantajId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public int? SirketId { get; set; }
        public bool? RenkTanimliMi { get; set; }
        public DateTime? TamGunSuresi { get; set; }
        public int? R { get; set; }
        public int? G { get; set; }
        public int? B { get; set; }
    }
}
