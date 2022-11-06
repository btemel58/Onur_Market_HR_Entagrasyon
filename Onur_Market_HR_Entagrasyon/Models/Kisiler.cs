using System;
using System.Collections.Generic;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Kisiler
    {
        public long KisiId { get; set; }
        public byte[] Foto { get; set; }
        public string AdSoyad { get; set; }
        public string SicilNo { get; set; }
        public string Unvan { get; set; }
        public DateTime? BaslangicT { get; set; }
        public DateTime? AyrilmaT { get; set; }
        public long TerminalNo { get; set; }
        public int? TerminalStatu { get; set; }
        public string TerminalKartNo { get; set; }
        public string TerminalSifre { get; set; }
        public float? Maas { get; set; }
        public bool? FazlaMesaiDurumu { get; set; }
        public string VatandaslikNo { get; set; }
        public string CepTel { get; set; }
        public string Eposta { get; set; }
        public string EvTel { get; set; }
        public string Dahili { get; set; }
        public DateTime? DogumT { get; set; }
        public int? Cinsiyet { get; set; }
        public int? EgitimDurumu { get; set; }
        public string EhliyetSinifi { get; set; }
        public int? AskerlikDurumu { get; set; }
        public int? SigaraDurumu { get; set; }
        public int? GozlukDurumu { get; set; }
        public string YabanciDil { get; set; }
        public string KanGrubu { get; set; }
        public int? Boy { get; set; }
        public int? Kilo { get; set; }
        public string Not1 { get; set; }
        public string Not2 { get; set; }
        public int? YemekKontor { get; set; }
        public string YemekBakiye { get; set; }
        public string BelgeNo { get; set; }
        public string AnneAdi { get; set; }
        public string AnneCepTel { get; set; }
        public string BabaAdi { get; set; }
        public string BabaCepTel { get; set; }
        public string IkametgahAdresi { get; set; }
        public int? SorumluKisiId1 { get; set; }
        public int? SorumluKisiId2 { get; set; }
        public int? SonGecisNoktasi { get; set; }
        public DateTime? SonGecisZamani { get; set; }
        public int? SonGirisNoktasi { get; set; }
        public DateTime? SonGirisZamani { get; set; }
        public int? SonCikisNoktasi { get; set; }
        public DateTime? SonCikisZamani { get; set; }
        public int? SonGecisDurumu { get; set; }
        public string EngellilikYuzdesi { get; set; }
        public int? DurumId { get; set; }
        public string DurumAciklamasi { get; set; }
        public int? StatuId { get; set; }
        public long? DepartmanId { get; set; }
        public int? YemekGrubuId { get; set; }
        public int? CalismaGrubuId { get; set; }
        public string OkuyucuYetkileri { get; set; }
        public int? TerminalYetkiGrubuId { get; set; }
        public int? SirketId { get; set; }
        public DateTime? OlusturulmaZamani { get; set; }
        public int? OlusturanKullaniciId { get; set; }
        public DateTime? DegisiklikZamani { get; set; }
        public long? DegisiklikYapanKullaniciId { get; set; }
        public bool? AktifMi { get; set; }
        public bool? ZiyaretciMi { get; set; }
        public int? YillikIzinGrubuId { get; set; }
        public int? YillikIzinKidem { get; set; }
        public int? YillikIzinDevir { get; set; }
        public int? SonYemekOgunu { get; set; }
        public int? SonYemekOgunSayisi { get; set; }
        public int? SonYemekGunToplami { get; set; }
        public DateTime? SonYemekGecisZamani { get; set; }
        public string PlakaNumarasi { get; set; }
        public string HgsNo { get; set; }
        public DateTime? GecerlilikTarihi { get; set; }
        public int? DaireId { get; set; }
        public bool SmsGidecekMi { get; set; }
        public bool YurttaKaliyorMu { get; set; }
        public string VeliCep { get; set; }
        public bool OgrenciMi { get; set; }
        public string TimezoneKodu { get; set; }
        public bool MobilKullaniciMi { get; set; }
        public string MobilSifre { get; set; }
        public bool YemekHakki { get; set; }
    }
}
