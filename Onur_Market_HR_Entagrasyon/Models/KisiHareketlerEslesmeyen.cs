using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiHareketlerEslesmeyen
    {
        public int KisiHareketId { get; set; }
        public string KartNo { get; set; }
        public DateTime? Zaman { get; set; }
        public long? TerminalId { get; set; }
        public int? TerminalOkuyucuId { get; set; }
        public int? GirisCikis { get; set; }
        public bool? IslenmeDurumu { get; set; }
        public int? IslenenKayitId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public int? GecisModu { get; set; }
    }
}
