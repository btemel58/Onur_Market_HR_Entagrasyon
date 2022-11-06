using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class OtomatikBakiye
    {
        public long Id { get; set; }
        public long KisiId { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Tutar { get; set; }
        public string EskiBakiye { get; set; }
    }
}
