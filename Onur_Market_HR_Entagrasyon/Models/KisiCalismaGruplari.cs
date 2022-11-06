using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class KisiCalismaGruplari
    {
        public int KisiCalismaGruplariId { get; set; }
        public int KisiId { get; set; }
        public int CalismaGrubuId { get; set; }
        public DateTime Tarih { get; set; }
        public int SirketId { get; set; }
    }
}
