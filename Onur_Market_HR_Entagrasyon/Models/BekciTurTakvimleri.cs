using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BekciTurTakvimleri
    {
        public int Id { get; set; }
        public int BekciId { get; set; }
        public int TurId { get; set; }
        public int Gun { get; set; }
        public int SirketId { get; set; }
    }
}
