using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Ayarlar
    {
        public int SirketId { get; set; }
        public int? ZtkartBosYetki { get; set; }
        public int? ZtkartYetki { get; set; }
        public DateTime? SonGuncellemeZamani { get; set; }
        public DateTime? SonGuncellemeZamani2 { get; set; }
        public DateTime? SonGuncellemeZamani3 { get; set; }
    }
}
