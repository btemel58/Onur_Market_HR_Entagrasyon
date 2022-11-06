using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class BekciOlaylar
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public byte[] Foto1 { get; set; }
        public byte[] Foto2 { get; set; }
        public int BekciId { get; set; }
        public int SirketId { get; set; }
        public DateTime Zaman { get; set; }
    }
}
