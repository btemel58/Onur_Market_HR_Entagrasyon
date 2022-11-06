using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Sirketler
    {
        public int SirketId { get; set; }
        public string SirketAdi { get; set; }
        public byte[] SirketLogo { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public string SirketUnvani { get; set; }
        public string TelefonNo { get; set; }
        public string WebSitesi { get; set; }
        public string Adres { get; set; }
        public bool? SicilTerminalNoEsitle { get; set; }
    }
}
