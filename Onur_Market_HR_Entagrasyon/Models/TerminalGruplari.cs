using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class TerminalGruplari
    {
        public int TerminalGrupId { get; set; }
        public string GrupAdi { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
    }
}
