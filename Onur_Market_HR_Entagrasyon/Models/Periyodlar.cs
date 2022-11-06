using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Periyodlar
    {
        public int PeriyodId { get; set; }
        public int? AltCalismaGrubuId { get; set; }
        public int? Gun { get; set; }
        public int? CalismaGrubuId { get; set; }
        public bool? IzinMi { get; set; }
        public int? SirketId { get; set; }
    }
}
