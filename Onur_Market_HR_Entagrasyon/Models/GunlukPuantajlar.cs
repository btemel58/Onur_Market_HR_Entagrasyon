using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class GunlukPuantajlar
    {
        public int GunlukPuantajId { get; set; }
        public int? KisiId { get; set; }
        public DateTime? Gun { get; set; }
        public int? PuantajTipi { get; set; }
        public DateTime? Zaman { get; set; }
        public int? KayitId { get; set; }
        public int? SirketId { get; set; }
        public bool? IzinMi { get; set; }
    }
}
