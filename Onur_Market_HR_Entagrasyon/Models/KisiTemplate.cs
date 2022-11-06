using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiTemplate
    {
        public long KisiTempId { get; set; }
        public int? KisiId { get; set; }
        public int? Fpindex { get; set; }
        public string Temp { get; set; }
        public DateTime? OlusturmaZamani { get; set; }
        public int? Len { get; set; }
    }
}
