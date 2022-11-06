using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class SmsLogs
    {
        public long Id { get; set; }
        public long KisiId { get; set; }
        public string GonderilenTelefon { get; set; }
        public string Mesaj { get; set; }
        public bool GonderildiMi { get; set; }
        public DateTime GonderilmeZamani { get; set; }
        public string SaglayiciDonus { get; set; }
    }
}
