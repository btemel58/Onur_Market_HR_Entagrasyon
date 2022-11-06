using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Logs
    {
        public int LogId { get; set; }
        public int? KullaniciId { get; set; }
        public int? SirketId { get; set; }
        public string IslemAciklamasi { get; set; }
        public int? KisiId { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
