using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KartSablonlari
    {
        public int KartSablonId { get; set; }
        public string KartSablonAdi { get; set; }
        public byte[] Arkaplan { get; set; }
        public string OnYazi { get; set; }
        public string Aciklama { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegistirilmeZamani { get; set; }
        public int? DegistirenKullaniciId { get; set; }
        public int? SirketId { get; set; }
    }
}
