using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class YemekOgunAdlari
    {
        public int OgunAdiId { get; set; }
        public string OgunAdi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullanici { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullanici { get; set; }
        public bool AktifMi { get; set; }
        public int? SirketId { get; set; }
    }
}
