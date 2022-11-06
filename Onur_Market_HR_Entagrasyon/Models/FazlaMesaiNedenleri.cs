using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class FazlaMesaiNedenleri
    {
        public int NedenId { get; set; }
        public string NedenAdi { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullanici { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullanici { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
    }
}
