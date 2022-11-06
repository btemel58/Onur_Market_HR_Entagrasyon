using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class OzelRaporAlanlari
    {
        public int OzelRaporAlanId { get; set; }
        public string OzelRaporId { get; set; }
        public string AlanAdi { get; set; }
        public string Kodu { get; set; }
        public string VeriTipi { get; set; }
        public bool? BaglantiliMi { get; set; }
        public string BaglantiliTablo { get; set; }
        public string BaglantiliSutunAdi { get; set; }
        public string GosterilecekSutunAdi { get; set; }
        public bool? Siralama { get; set; }
    }
}
