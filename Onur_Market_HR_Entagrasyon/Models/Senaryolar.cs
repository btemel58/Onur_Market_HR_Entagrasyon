using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Senaryolar
    {
        public int SenaryoId { get; set; }
        public string SenaryoAdi { get; set; }
        public int Tip { get; set; }
        public int Gun { get; set; }
        public DateTime Zaman { get; set; }
        public string TerminalIdListesi { get; set; }
        public int Islem { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public int? DegistirenKullaniciId { get; set; }
        public DateTime? DegistirmeZamani { get; set; }
        public int SirketId { get; set; }
    }
}
