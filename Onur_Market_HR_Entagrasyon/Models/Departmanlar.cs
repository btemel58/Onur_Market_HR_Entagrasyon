using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Departmanlar
    {
        public int DepartmanId { get; set; }
        public string DepartmanAdi { get; set; }
        public int? AnaDepartman { get; set; }
        public string Agac { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegistirilmeZamani { get; set; }
        public int? DegistirenKullaniciId { get; set; }
        public int? SirketId { get; set; }
        public int Siralama { get; set; }
    }
}
