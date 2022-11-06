using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class TerminalLoglari
    {
        public long TerminalLogId { get; set; }
        public int? TerminalId { get; set; }
        public int? TerminalOkuyucuId { get; set; }
        public string CardNo { get; set; }
        public DateTime? Zaman { get; set; }
        public string AnaKonu { get; set; }
        public string Olay { get; set; }
    }
}
