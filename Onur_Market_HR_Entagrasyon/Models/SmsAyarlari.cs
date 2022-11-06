using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class SmsAyarlari
    {
        public int Id { get; set; }
        public string ApiLink { get; set; }
        public string Baslik { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public bool AktifMi { get; set; }
        public string Icerik1 { get; set; }
        public string Icerik2 { get; set; }
        public string Icerik3 { get; set; }
        public string Icerik4 { get; set; }
        public bool Gun1AktifMi { get; set; }
        public DateTime? Gun1SonGiris { get; set; }
        public bool Gun2AktifMi { get; set; }
        public DateTime? Gun2SonGiris { get; set; }
        public bool Gun3AktifMi { get; set; }
        public DateTime? Gun3SonGiris { get; set; }
        public bool Gun4AktifMi { get; set; }
        public DateTime? Gun4SonGiris { get; set; }
        public bool Gun5AktifMi { get; set; }
        public DateTime? Gun5SonGiris { get; set; }
        public bool Gun6AktifMi { get; set; }
        public DateTime? Gun6SonGiris { get; set; }
        public bool Gun7AktifMi { get; set; }
        public DateTime? Gun7SonGiris { get; set; }
        public string KontrolKapilari { get; set; }
    }
}
