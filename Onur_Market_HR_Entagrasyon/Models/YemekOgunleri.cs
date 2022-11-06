using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class YemekOgunleri
    {
        public int OgunId { get; set; }
        public int? YemekGrupId { get; set; }
        public int? OgunAdiId { get; set; }
        public int? Gun { get; set; }
        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }
        public int? YemekYemeAdedi { get; set; }
        public string Ucret { get; set; }
        public string Ucret2 { get; set; }
    }
}
