using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BekciHareketler
    {
        public int Id { get; set; }
        public int GecisNoktaId { get; set; }
        public DateTime OkutmaZamani { get; set; }
        public bool OnlineOkutmaMi { get; set; }
        public int BekciId { get; set; }
        public int SirketId { get; set; }
        public string Konum { get; set; }
    }
}
