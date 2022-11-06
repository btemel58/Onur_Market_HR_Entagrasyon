using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class YemekGruplari
    {
        public int YemekGrupId { get; set; }
        public string YemekGrubuAdi { get; set; }
        public int? GrupTipi { get; set; }
        public bool? HerOgundeTekYemek { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullanici { get; set; }
        public DateTime? DegistirilmeZamani { get; set; }
        public int? DegistirenKullanici { get; set; }
        public int? GunlukYemekAdeti { get; set; }
    }
}
