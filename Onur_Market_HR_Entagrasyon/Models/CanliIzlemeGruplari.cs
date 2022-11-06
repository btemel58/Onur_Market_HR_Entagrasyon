using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class CanliIzlemeGruplari
    {
        public int CanliIzlemeId { get; set; }
        public string GrupAdi { get; set; }
        public string Okuyucular { get; set; }
        public int? SirketId { get; set; }
    }
}
