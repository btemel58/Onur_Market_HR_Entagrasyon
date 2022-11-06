using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KartDizaynSablonlari
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public byte[] ArkaPlan { get; set; }
        public string Sablon { get; set; }
        public string ArkaPlanRenk { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int? SilenKullaniciId { get; set; }
    }
}
