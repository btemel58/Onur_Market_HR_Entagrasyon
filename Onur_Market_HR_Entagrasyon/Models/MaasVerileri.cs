using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class MaasVerileri
    {
        public int MaasId { get; set; }
        public string MaasAdi { get; set; }
        public int? MaasArtiEksi { get; set; }
        public bool? AktifMi { get; set; }
        public int? SirketId { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
    }
}
