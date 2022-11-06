using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class CalismaGruplariGirisCikis
    {
        public int GirisCikisId { get; set; }
        public int? CalismaGrubuId { get; set; }
        public DateTime? GirisZamani { get; set; }
        public DateTime? CikisZamani { get; set; }
        public int? SirketId { get; set; }
    }
}
