using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BekciKontrolNoktalari
    {
        public int Id { get; set; }
        public string NoktaAdi { get; set; }
        public int BolgeId { get; set; }
        public int SirketId { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int? SilenKullaniciId { get; set; }
        public string ResimYolu { get; set; }
    }
}
