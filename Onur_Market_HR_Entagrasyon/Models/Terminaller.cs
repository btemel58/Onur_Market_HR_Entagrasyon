using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Terminaller
    {
        public int TerminalId { get; set; }
        public int? TerminalNo { get; set; }
        public string Ipadres { get; set; }
        public string Port { get; set; }
        public string TerminalAdi { get; set; }
        public string TerminalGrupId { get; set; }
        public string TerminalModel { get; set; }
        public string Platform { get; set; }
        public string Fpalgoritma { get; set; }
        public string FirmwareVersiyon { get; set; }
        public string Macadres { get; set; }
        public string SeriNumarasi { get; set; }
        public string Uretici { get; set; }
        public DateTime? UretimZamani { get; set; }
        public int? Bilgi { get; set; }
        public int? Statu { get; set; }
        public int? GirisCikis { get; set; }
        public int? RoleSuresi { get; set; }
        public bool? CanliIzleme { get; set; }
        public bool? PanelMi { get; set; }
        public string AdminSifresi { get; set; }
        public DateTime? SonBaglantiZamani { get; set; }
        public DateTime? SonBilgiToplamaZamani { get; set; }
        public DateTime? SonSenkronizeZamani { get; set; }
        public string SonBaglantiDurumu { get; set; }
        public bool? AktifMi { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? SirketId { get; set; }
        public bool? KartMi { get; set; }
        public bool? ParmakIziMi { get; set; }
        public bool? YuzIziMi { get; set; }
        public bool AntiPassbackVarMi { get; set; }
        public bool ZamanSinirlamasiVarmi { get; set; }
        public bool AnlikBaglanti { get; set; }
        public bool CihazOnlineMi { get; set; }
        public bool SilindiMi { get; set; }
    }
}
