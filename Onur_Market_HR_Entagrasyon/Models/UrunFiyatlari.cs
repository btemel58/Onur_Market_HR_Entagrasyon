using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class UrunFiyatlari
    {
        public int UrunFiyatId { get; set; }
        public int? UrunId { get; set; }
        public decimal? BayiAlis { get; set; }
        public decimal? SonKullaniciAlis { get; set; }
        public int? BayiId { get; set; }
        public int? UrunParaBirimiId { get; set; }
    }
}
