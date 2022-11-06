using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class EkPuantajlar
    {
        public int EkPuantajId { get; set; }
        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }
        public int? PuantajTipId { get; set; }
        public int? PuantajTipi { get; set; }
        public bool? Hakedis { get; set; }
        public int? CalismaGrupId { get; set; }
        public int? TatilId { get; set; }
        public int? SirketId { get; set; }
    }
}
