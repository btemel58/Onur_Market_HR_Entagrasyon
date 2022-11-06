using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Tatiller
    {
        public int TatilId { get; set; }
        public string Adi { get; set; }
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public bool? YilTekrari { get; set; }
        public string EtkilenenCalismaGruplari { get; set; }
        public string EkPuantajlar { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public long? DegisiklikYapanKullaniciId { get; set; }
        public bool? AktifMi { get; set; }
        public int? SirketId { get; set; }
    }
}
