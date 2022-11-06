using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BekciTurDetaylari
    {
        public int Id { get; set; }
        public int BekciTurId { get; set; }
        public int BekciKontrolNoktaId { get; set; }
        public DateTime Zaman { get; set; }
        public int SirketId { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int? SilenKullaniciId { get; set; }
    }
}
