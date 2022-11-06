using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Satislar
    {
        public int Id { get; set; }
        public double Tutar { get; set; }
        public long KisiId { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int? SilenKullaniciId { get; set; }
        public int SirketId { get; set; }
    }
}
