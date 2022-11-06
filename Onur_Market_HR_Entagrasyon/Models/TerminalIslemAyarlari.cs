using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class TerminalIslemAyarlari
    {
        public int AyarId { get; set; }
        public DateTime? BaglantiZamanAsimiSuresi { get; set; }
        public int? SirketId { get; set; }
    }
}
