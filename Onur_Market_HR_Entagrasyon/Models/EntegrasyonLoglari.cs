using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class EntegrasyonLoglari
    {
        public int Id { get; set; }
        public DateTime Zaman { get; set; }
        public string Olay { get; set; }
    }
}
