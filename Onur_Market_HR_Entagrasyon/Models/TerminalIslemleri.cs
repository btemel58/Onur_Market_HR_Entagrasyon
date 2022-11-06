using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class TerminalIslemleri
    {
        public long TerminalIslemId { get; set; }
        public int? KisiId { get; set; }
        public int? Komut { get; set; }
        public int? TerminalId { get; set; }
        public int? OkuyucuId { get; set; }
        public DateTime? Zaman { get; set; }
        public bool? Tekrar { get; set; }
        public int? Gun { get; set; }
        public int? Fpindex { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public long? OlusturanKullaniciId { get; set; }
        public int? SirketId { get; set; }
        public int? TerminalNo { get; set; }
        public string TerminalKartNo { get; set; }
    }
}
