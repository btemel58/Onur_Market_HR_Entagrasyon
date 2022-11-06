using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class TerminalOkuyuculari
    {
        public int OkuyucuId { get; set; }
        public int? TerminalId { get; set; }
        public string OkuyucuAdi { get; set; }
        public int? OkuyucuNo { get; set; }
        public int? KapiTipi { get; set; }
        public int? SirketId { get; set; }
        public int? Gc { get; set; }
        public bool? AktifMi { get; set; }
        public string OkuyucuDurumu { get; set; }
        public string InputAdi { get; set; }
    }
}
