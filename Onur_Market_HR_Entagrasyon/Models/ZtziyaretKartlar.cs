using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class ZtziyaretKartlar
    {
        public int ZiyaretKartId { get; set; }
        public string KartAdi { get; set; }
        public string TerminalNo { get; set; }
        public string KartNo { get; set; }
        public string GecisKapi { get; set; }
        public string Durum { get; set; }
        public string SonKisi { get; set; }
        public string Yer { get; set; }
        public int? KartGrubuId { get; set; }
        public int? KisiId { get; set; }
        public int? SirketId { get; set; }
        public bool? AktifMi { get; set; }
    }
}
