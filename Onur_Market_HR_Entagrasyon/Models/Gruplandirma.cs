using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Gruplandirma
    {
        public int GrupId { get; set; }
        public string Tanim { get; set; }
        public int SirketId { get; set; }
        public bool AktifMi { get; set; }
    }
}
