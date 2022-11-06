using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BakiyeLoglari
    {
        public int LogId { get; set; }
        public long KisiId { get; set; }
        public int BakiyeTipi { get; set; }
        public DateTime YuklenmeTarihi { get; set; }
        public string Miktar { get; set; }
        public bool EklendiMi { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public int SirketId { get; set; }
    }
}
