using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiDurumlari
    {
        public int KisiDurumId { get; set; }
        public string DurumAdi { get; set; }
        public bool? DurumStatu { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
    }
}
