using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Ztziyaretciler
    {
        public int ZiyaretciId { get; set; }
        public string AdSoyad { get; set; }
        public string VatandaslikNo { get; set; }
        public string GelisNedeni { get; set; }
        public string Aciklama { get; set; }
        public string KimeSicil { get; set; }
        public string KimeAd { get; set; }
        public string Nereye { get; set; }
        public int? KartId { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? GirisS { get; set; }
        public DateTime? CikisS { get; set; }
        public byte[] Foto { get; set; }
        public string KartAdi { get; set; }
        public string KartNo { get; set; }
        public string CepTel { get; set; }
        public int? KisiId { get; set; }
        public int? SirketId { get; set; }
    }
}
