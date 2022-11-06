using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class UrunOzellikleri
    {
        public long UrunOzellikId { get; set; }
        public string OzellikAdi { get; set; }
        public string OzellikDegeri { get; set; }
        public int? UrunId { get; set; }
    }
}
