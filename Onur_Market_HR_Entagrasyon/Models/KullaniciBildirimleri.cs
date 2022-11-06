using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KullaniciBildirimleri
    {
        public int KullaniciBildirimId { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
        public int? KullaniciId { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
    }
}
