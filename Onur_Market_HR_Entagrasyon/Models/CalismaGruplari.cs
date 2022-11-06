using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class CalismaGruplari
    {
        public int CalismaGrubuId { get; set; }
        public int? Tipi { get; set; }
        public string Adi { get; set; }
        public string KisaKodu { get; set; }
        public DateTime? GirisZamani { get; set; }
        public DateTime? CikisZamani { get; set; }
        public DateTime? ErkenGirisZamani { get; set; }
        public DateTime? ErkenCikisZamani { get; set; }
        public DateTime? GecGirisZamani { get; set; }
        public DateTime? GecCikisZamani { get; set; }
        public DateTime? YemekBaslangic { get; set; }
        public DateTime? YemekBitis { get; set; }
        public DateTime? ToplamYemekSuresi { get; set; }
        public DateTime? ToplamCalismaSuresi { get; set; }
        public DateTime? ToplamMolaSuresi { get; set; }
        public DateTime? ToplamFazlaMesai { get; set; }
        public bool? IlkGsonC { get; set; }
        public DateTime? GunAtlatmaSaati { get; set; }
        public DateTime? GunDonumSaati { get; set; }
        public DateTime? UstSinir { get; set; }
        public DateTime? AltSinir { get; set; }
        public bool? GirisYapilanGunuEsasAl { get; set; }
        public bool? KapiKontroluYap { get; set; }
        public DateTime? HareketleriTekeIndir { get; set; }
        public bool? FarkliKapilariSil { get; set; }
        public bool? OnaylananFazlaMesaileriSilme { get; set; }
        public bool? PeriyodMu { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public int? DegisiklikYapanKullaniciId { get; set; }
        public bool? AktifMi { get; set; }
        public int? SirketId { get; set; }
        public DateTime? PeriyodBaslangic { get; set; }
        public DateTime? DevamsizlikGunSuresi { get; set; }
    }
}
