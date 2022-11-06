using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class ZtkaraListe
    {
        public int KaraListeId { get; set; }
        public string KisiAdi { get; set; }
        public string Aciklama { get; set; }
        public int? SirketId { get; set; }
        public string VatandaslikNo { get; set; }
    }
}
