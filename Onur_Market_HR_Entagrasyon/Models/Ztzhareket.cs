using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Ztzhareket
    {
        public int HareketId { get; set; }
        public string TerminalNo { get; set; }
        public string Sicil { get; set; }
        public string Cihaz { get; set; }
        public DateTime? Hareket { get; set; }
    }
}
