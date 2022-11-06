using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class DaireTipleri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public bool AktifMi { get; set; }
        public int SirketId { get; set; }
        public int SiraNo { get; set; }
    }
}
