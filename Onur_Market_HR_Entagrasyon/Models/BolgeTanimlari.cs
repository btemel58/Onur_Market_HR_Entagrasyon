using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BolgeTanimlari
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Tip { get; set; }
        public bool AktifMi { get; set; }
        public int SirketId { get; set; }
        public int? KatId { get; set; }
        public int? BolgeId { get; set; }
        public int Kapasite { get; set; }
        public int? DaireTipiId { get; set; }
        public int SiraNo { get; set; }
    }
}
