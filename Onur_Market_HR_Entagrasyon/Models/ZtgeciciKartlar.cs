using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class ZtgeciciKartlar
    {
        public int GeciciKartId { get; set; }
        public int? KisiId { get; set; }
        public string KartNo { get; set; }
        public DateTime? VerilisZamani { get; set; }
        public DateTime? SonGecerlilik { get; set; }
        public DateTime? CikisZamani { get; set; }
        public int? KartId { get; set; }
        public int? SirketId { get; set; }
    }
}
