using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class MailGorevleri
    {
        public int Id { get; set; }
        public string GorevAdi { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Raporlar { get; set; }
        public string Epostalar { get; set; }
        public int Gun { get; set; }
        public DateTime Saat { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime? DegistirilmeZamani { get; set; }
        public int? DegistirenKullaniciId { get; set; }
        public bool AktifMi { get; set; }
        public int SirketId { get; set; }
        public int RaporTipi { get; set; }
        public int FiltreTipi { get; set; }
        public string Filtre { get; set; }
        public string SorumluKisiler { get; set; }
    }
}
