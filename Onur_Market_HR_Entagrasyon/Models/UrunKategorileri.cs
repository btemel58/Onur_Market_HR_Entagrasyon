using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class UrunKategorileri
    {
        public int UrunKategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public int? AnaKategoriId { get; set; }
    }
}
