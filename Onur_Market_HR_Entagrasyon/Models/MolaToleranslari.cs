using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class MolaToleranslari
    {
        public int MolaToleransId { get; set; }
        public DateTime? SaatlikIsZamani { get; set; }
        public DateTime? MolaToleransi { get; set; }
        public int? CalismaGrubuId { get; set; }
        public int? SirketId { get; set; }
    }
}
