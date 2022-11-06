using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Bekciler
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Unvan { get; set; }
        public string Eposta { get; set; }
        public string Parola { get; set; }
        public byte[] Foto { get; set; }
        public string Telefon { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int SilenKullaniciId { get; set; }
        public int SirketId { get; set; }
    }
}
