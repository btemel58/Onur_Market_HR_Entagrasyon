using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiKayitlar
    {
        public int KisiKayitId { get; set; }
        public int? KisiId { get; set; }
        public DateTime? Zaman { get; set; }
        public int? GirisHareketId { get; set; }
        public int? GirisOkuyucuId { get; set; }
        public DateTime? GirisZamani { get; set; }
        public long? CikisHareketId { get; set; }
        public int? CikisOkuyucuId { get; set; }
        public DateTime? CikisZamani { get; set; }
        public int? CalismaGrubuId { get; set; }
        public bool? IslemeDurumu { get; set; }
        public int? SirketId { get; set; }
    }
}
