using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiMaasVerileri
    {
        public long KisiMaasId { get; set; }
        public long? KisiId { get; set; }
        public int? MaasId { get; set; }
        public double? Tutar { get; set; }
        public DateTime? Zaman { get; set; }
        public bool? AktifMi { get; set; }
        public int? SirketId { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public int? OlusturmaKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
    }
}
