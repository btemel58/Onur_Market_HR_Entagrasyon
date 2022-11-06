using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Kullanicilar
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Unvan { get; set; }
        public int? YetkiId { get; set; }
        public int? AktifSirket { get; set; }
        public string Parola { get; set; }
        public byte[] ProfilFoto { get; set; }
        public int? CanliIzlemeGrubu { get; set; }
        public string ZtkartGrubu { get; set; }
        public string YetkiliSirketler { get; set; }
        public bool? AktifMi { get; set; }
        public string Departmanlar { get; set; }
        public string Eposta { get; set; }
        public string RaporYetkileri { get; set; }
        public bool SmsGidecekMi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Filtre { get; set; }
        public bool SilindiMi { get; set; }
    }
}
