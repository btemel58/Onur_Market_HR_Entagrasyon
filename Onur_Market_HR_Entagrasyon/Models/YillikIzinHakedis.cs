using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class YillikIzinHakedis
    {
        public int HakedisId { get; set; }
        public int? YillikIzinGrupId { get; set; }
        public int? Baslangic { get; set; }
        public int? Bitis { get; set; }
        public int? Hakedis { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullanici { get; set; }
        public DateTime? DegistirilmeZamani { get; set; }
        public int? DegistirenKullanici { get; set; }
    }
}
