using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class ZtkartGruplari
    {
        public int KartGrubuId { get; set; }
        public string Adi { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
        public string Okuyucular { get; set; }
    }
}
