using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiHareketler
    {
        public int KisiHareketId { get; set; }
        public int? KisiId { get; set; }
        public DateTime? Zaman { get; set; }
        public int? TerminalId { get; set; }
        public int? TerminalOkuyucuId { get; set; }
        public int? GirisCikis { get; set; }
        public int? IslenmeDurumu { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public int? GecisModu { get; set; }
        public DateTime? KabulZaman { get; set; }
        public int? KabulGirisCikis { get; set; }
        public int? CalismaGrupId { get; set; }
        public int? OgunAdiId { get; set; }
        public double? Ucret { get; set; }
        public bool Transfer { get; set; }
        public int SirketId { get; set; }
        public string KonumX { get; set; }
        public string KonumY { get; set; }
    }
}
