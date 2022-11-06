using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Shifts
    {
        public int Id { get; set; }
        public long KisiId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int? IzinId { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int SilenKullaniciId { get; set; }
        public int SirketId { get; set; }
    }
}
