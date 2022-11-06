using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class IzinTalepleri
    {
        public int Id { get; set; }
        public long KisiId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string Aciklama { get; set; }
        public int Onay { get; set; }
        public int? IslemYapanKullaniciId { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public string IslemAciklama { get; set; }
    }
}
