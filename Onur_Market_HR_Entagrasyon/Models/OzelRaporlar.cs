using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class OzelRaporlar
    {
        public int OzelRaporId { get; set; }
        public string OzelRaporAdi { get; set; }
        public string OzelRaporGrubu { get; set; }
        public string Modul { get; set; }
        public string TabloAdi { get; set; }
        public string OzelRaporAciklamasi { get; set; }
        public string FormulKodu { get; set; }
        public string AnahtarDizin { get; set; }
        public bool? KisiFiltresi { get; set; }
    }
}
