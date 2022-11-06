using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiFazlaMesailer
    {
        public long KisiFazlaMesaiId { get; set; }
        public int? KisiId { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Hesaplanan { get; set; }
        public DateTime? Onaylanan { get; set; }
        public int? SirketId { get; set; }
        public int? Nedeni { get; set; }
        public int? Masraf { get; set; }
        public int? FazlaMesaiTipiId { get; set; }
    }
}
