using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiFiltreGruplari
    {
        public int KisiFiltreGrubuId { get; set; }
        public string FiltreGrubuAdi { get; set; }
        public int GrupId { get; set; }
        public string FiltreGrubuDegeri { get; set; }
        public int KisiId { get; set; }
        public int SirketId { get; set; }
    }
}
