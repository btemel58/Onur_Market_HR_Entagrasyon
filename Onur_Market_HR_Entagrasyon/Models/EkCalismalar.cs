using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class EkCalismalar
    {
        public int EkCalismaId { get; set; }
        public int? AltCalismaGrubuId { get; set; }
        public int? CalismaGrubuId { get; set; }
        public int? SirketId { get; set; }
    }
}
