using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Ztbeklenenler
    {
        public int BeklenenId { get; set; }
        public string BeklenenAdi { get; set; }
        public string Kime { get; set; }
        public string KimeSicil { get; set; }
        public string GelisNedeni { get; set; }
        public DateTime? Randevu { get; set; }
        public string Aciklama { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public int? OlusturanKullanici { get; set; }
        public int? KisiId { get; set; }
        public int? SirketId { get; set; }
        public string VatandaslikNo { get; set; }
    }
}
