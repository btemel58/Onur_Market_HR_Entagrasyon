using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class TerminalYetkiGruplari
    {
        public int TerminalYetkiGrubuId { get; set; }
        public string GrupAdi { get; set; }
        public string Okuyucular { get; set; }
        public bool? YeniTerminallerEklensinMi { get; set; }
        public bool? AktifMi { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? SirketId { get; set; }
        public bool AntiPassbacktenEtkilenirMi { get; set; }
    }
}
