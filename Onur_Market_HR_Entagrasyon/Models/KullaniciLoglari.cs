using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KullaniciLoglari
    {
        public int LogId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Kullanici { get; set; }
        public string Islem { get; set; }
    }
}
