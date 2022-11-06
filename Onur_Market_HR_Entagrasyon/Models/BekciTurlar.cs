using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BekciTurlar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public DateTime BaslangicZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public int SirketId { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public int? SilenKullaniciId { get; set; }
    }
}
