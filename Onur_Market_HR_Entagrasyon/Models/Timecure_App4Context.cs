using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Onur_Market_HR_Entagrasyon.Models
{
    public partial class Timecure_App4Context : DbContext
    {
        public Timecure_App4Context()
        {
        }

        public Timecure_App4Context(DbContextOptions<Timecure_App4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Ayarlar> Ayarlar { get; set; }
        public virtual DbSet<AylikPuantajTablosu> AylikPuantajTablosu { get; set; }
        public virtual DbSet<BakiyeLoglari> BakiyeLoglari { get; set; }
        public virtual DbSet<BekciBolgeler> BekciBolgeler { get; set; }
        public virtual DbSet<BekciHareketler> BekciHareketler { get; set; }
        public virtual DbSet<BekciKontrolNoktalari> BekciKontrolNoktalari { get; set; }
        public virtual DbSet<BekciOlaylar> BekciOlaylar { get; set; }
        public virtual DbSet<BekciTurDetaylari> BekciTurDetaylari { get; set; }
        public virtual DbSet<BekciTurTakvimleri> BekciTurTakvimleri { get; set; }
        public virtual DbSet<BekciTurlar> BekciTurlar { get; set; }
        public virtual DbSet<Bekciler> Bekciler { get; set; }
        public virtual DbSet<BolgeTanimlari> BolgeTanimlari { get; set; }
        public virtual DbSet<CalismaGruplari> CalismaGruplari { get; set; }
        public virtual DbSet<CalismaGruplariGirisCikis> CalismaGruplariGirisCikis { get; set; }
        public virtual DbSet<CanliIzlemeGruplari> CanliIzlemeGruplari { get; set; }
        public virtual DbSet<DaireTipleri> DaireTipleri { get; set; }
        public virtual DbSet<Departmanlar> Departmanlar { get; set; }
        public virtual DbSet<EkCalismalar> EkCalismalar { get; set; }
        public virtual DbSet<EkPuantajlar> EkPuantajlar { get; set; }
        public virtual DbSet<EntegrasyonLoglari> EntegrasyonLoglari { get; set; }
        public virtual DbSet<FazlaMesaiMasrafYerleri> FazlaMesaiMasrafYerleri { get; set; }
        public virtual DbSet<FazlaMesaiNedenleri> FazlaMesaiNedenleri { get; set; }
        public virtual DbSet<Gruplandirma> Gruplandirma { get; set; }
        public virtual DbSet<GunlukPuantajlar> GunlukPuantajlar { get; set; }
        public virtual DbSet<IzinTalepleri> IzinTalepleri { get; set; }
        public virtual DbSet<Izinler> Izinler { get; set; }
        public virtual DbSet<KartDizaynSablonlari> KartDizaynSablonlari { get; set; }
        public virtual DbSet<KartSablonlari> KartSablonlari { get; set; }
        public virtual DbSet<KisiCalismaGruplari> KisiCalismaGruplari { get; set; }
        public virtual DbSet<KisiCalismalar> KisiCalismalar { get; set; }
        public virtual DbSet<KisiDurumlari> KisiDurumlari { get; set; }
        public virtual DbSet<KisiFazlaMesailer> KisiFazlaMesailer { get; set; }
        public virtual DbSet<KisiFiltreGruplari> KisiFiltreGruplari { get; set; }
        public virtual DbSet<KisiHareketler> KisiHareketler { get; set; }
        public virtual DbSet<KisiHareketlerEslesmeyen> KisiHareketlerEslesmeyen { get; set; }
        public virtual DbSet<KisiIslemleri> KisiIslemleri { get; set; }
        public virtual DbSet<KisiIslemleriOzel> KisiIslemleriOzel { get; set; }
        public virtual DbSet<KisiIzinler> KisiIzinler { get; set; }
        public virtual DbSet<KisiKayitlar> KisiKayitlar { get; set; }
        public virtual DbSet<KisiMaasVerileri> KisiMaasVerileri { get; set; }
        public virtual DbSet<KisiStatuleri> KisiStatuleri { get; set; }
        public virtual DbSet<KisiTemplate> KisiTemplate { get; set; }
        public virtual DbSet<Kisiler> Kisiler { get; set; }
        public virtual DbSet<KullaniciBildirimleri> KullaniciBildirimleri { get; set; }
        public virtual DbSet<KullaniciLoglari> KullaniciLoglari { get; set; }
        public virtual DbSet<KullaniciYetkileri> KullaniciYetkileri { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<MaasVerileri> MaasVerileri { get; set; }
        public virtual DbSet<MailGorevleri> MailGorevleri { get; set; }
        public virtual DbSet<MolaToleranslari> MolaToleranslari { get; set; }
        public virtual DbSet<OtomatikBakiye> OtomatikBakiye { get; set; }
        public virtual DbSet<OzelRaporAlanlari> OzelRaporAlanlari { get; set; }
        public virtual DbSet<OzelRaporOzellikleri> OzelRaporOzellikleri { get; set; }
        public virtual DbSet<OzelRaporSablonlari> OzelRaporSablonlari { get; set; }
        public virtual DbSet<OzelRaporlar> OzelRaporlar { get; set; }
        public virtual DbSet<Periyodlar> Periyodlar { get; set; }
        public virtual DbSet<PuantajTipleri> PuantajTipleri { get; set; }
        public virtual DbSet<RaporSablonu> RaporSablonu { get; set; }
        public virtual DbSet<Satislar> Satislar { get; set; }
        public virtual DbSet<Senaryolar> Senaryolar { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<Sirketler> Sirketler { get; set; }
        public virtual DbSet<SmsAyarlari> SmsAyarlari { get; set; }
        public virtual DbSet<SmsLogs> SmsLogs { get; set; }
        public virtual DbSet<Tatiller> Tatiller { get; set; }
        public virtual DbSet<TerminalGruplari> TerminalGruplari { get; set; }
        public virtual DbSet<TerminalIslemAyarlari> TerminalIslemAyarlari { get; set; }
        public virtual DbSet<TerminalIslemleri> TerminalIslemleri { get; set; }
        public virtual DbSet<TerminalLoglari> TerminalLoglari { get; set; }
        public virtual DbSet<TerminalOkuyuculari> TerminalOkuyuculari { get; set; }
        public virtual DbSet<TerminalYetkiGruplari> TerminalYetkiGruplari { get; set; }
        public virtual DbSet<Terminaller> Terminaller { get; set; }
        public virtual DbSet<UrunFiyatlari> UrunFiyatlari { get; set; }
        public virtual DbSet<UrunKategorileri> UrunKategorileri { get; set; }
        public virtual DbSet<UrunOzellikleri> UrunOzellikleri { get; set; }
        public virtual DbSet<UrunParaBirimleri> UrunParaBirimleri { get; set; }
        public virtual DbSet<UrunTedarikcileri> UrunTedarikcileri { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Veri> Veri { get; set; }
        public virtual DbSet<Yardim> Yardim { get; set; }
        public virtual DbSet<YemekGruplari> YemekGruplari { get; set; }
        public virtual DbSet<YemekOgunAdlari> YemekOgunAdlari { get; set; }
        public virtual DbSet<YemekOgunleri> YemekOgunleri { get; set; }
        public virtual DbSet<YillikIzinGruplari> YillikIzinGruplari { get; set; }
        public virtual DbSet<YillikIzinHakedis> YillikIzinHakedis { get; set; }
        public virtual DbSet<Ztayar> Ztayar { get; set; }
        public virtual DbSet<Ztbeklenenler> Ztbeklenenler { get; set; }
        public virtual DbSet<ZtgeciciKartlar> ZtgeciciKartlar { get; set; }
        public virtual DbSet<ZtgelisNedenleri> ZtgelisNedenleri { get; set; }
        public virtual DbSet<ZtkaraListe> ZtkaraListe { get; set; }
        public virtual DbSet<ZtkartGruplari> ZtkartGruplari { get; set; }
        public virtual DbSet<Ztzhareket> Ztzhareket { get; set; }
        public virtual DbSet<ZtziyaretKartlar> ZtziyaretKartlar { get; set; }
        public virtual DbSet<Ztziyaretciler> Ztziyaretciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=37.148.211.210\\\\\\\\SQLEXPRESS,1433;Database=Timecure_App4;Trusted_Connection=True;Integrated Security=false;User ID=sa;Password=Pdks1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ayarlar>(entity =>
            {
                entity.HasKey(e => e.SirketId);

                entity.Property(e => e.ZtkartBosYetki).HasColumnName("ZTKartBosYetki");

                entity.Property(e => e.ZtkartYetki).HasColumnName("ZTKartYetki");
            });

            modelBuilder.Entity<AylikPuantajTablosu>(entity =>
            {
                entity.HasKey(e => e.AylikPuantajId);

                entity.Property(e => e.Ssk).HasColumnName("SSK");
            });

            modelBuilder.Entity<BakiyeLoglari>(entity =>
            {
                entity.HasKey(e => e.LogId);
            });

            modelBuilder.Entity<CalismaGruplari>(entity =>
            {
                entity.HasKey(e => e.CalismaGrubuId);

                entity.Property(e => e.IlkGsonC).HasColumnName("IlkGSonC");
            });

            modelBuilder.Entity<CalismaGruplariGirisCikis>(entity =>
            {
                entity.HasKey(e => e.GirisCikisId);
            });

            modelBuilder.Entity<CanliIzlemeGruplari>(entity =>
            {
                entity.HasKey(e => e.CanliIzlemeId);

                entity.Property(e => e.GrupAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<Departmanlar>(entity =>
            {
                entity.HasKey(e => e.DepartmanId);
            });

            modelBuilder.Entity<EkCalismalar>(entity =>
            {
                entity.HasKey(e => e.EkCalismaId);
            });

            modelBuilder.Entity<EkPuantajlar>(entity =>
            {
                entity.HasKey(e => e.EkPuantajId);
            });

            modelBuilder.Entity<FazlaMesaiMasrafYerleri>(entity =>
            {
                entity.HasKey(e => e.MasrafId);

                entity.Property(e => e.MasrafAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<FazlaMesaiNedenleri>(entity =>
            {
                entity.HasKey(e => e.NedenId);

                entity.Property(e => e.NedenAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<Gruplandirma>(entity =>
            {
                entity.HasKey(e => e.GrupId);
            });

            modelBuilder.Entity<GunlukPuantajlar>(entity =>
            {
                entity.HasKey(e => e.GunlukPuantajId);

                entity.Property(e => e.IzinMi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Izinler>(entity =>
            {
                entity.HasKey(e => e.IzinId)
                    .HasName("PK_KisiIzinler");
            });

            modelBuilder.Entity<KartDizaynSablonlari>(entity =>
            {
                entity.Property(e => e.ArkaPlan).HasColumnType("image");
            });

            modelBuilder.Entity<KartSablonlari>(entity =>
            {
                entity.HasKey(e => e.KartSablonId);

                entity.Property(e => e.Aciklama).HasMaxLength(350);

                entity.Property(e => e.Arkaplan).HasColumnType("image");

                entity.Property(e => e.KartSablonAdi).HasMaxLength(250);

                entity.Property(e => e.OnYazi).HasMaxLength(150);
            });

            modelBuilder.Entity<KisiCalismaGruplari>(entity =>
            {
                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<KisiCalismalar>(entity =>
            {
                entity.HasKey(e => e.KisiIzinId)
                    .HasName("PK_KisiCalismalar_1");

                entity.Property(e => e.Aciklama).HasMaxLength(500);
            });

            modelBuilder.Entity<KisiDurumlari>(entity =>
            {
                entity.HasKey(e => e.KisiDurumId);

                entity.Property(e => e.DurumAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<KisiFazlaMesailer>(entity =>
            {
                entity.HasKey(e => e.KisiFazlaMesaiId);
            });

            modelBuilder.Entity<KisiFiltreGruplari>(entity =>
            {
                entity.HasKey(e => e.KisiFiltreGrubuId);

                entity.Property(e => e.FiltreGrubuAdi).HasMaxLength(200);

                entity.Property(e => e.FiltreGrubuDegeri).HasMaxLength(200);
            });

            modelBuilder.Entity<KisiHareketler>(entity =>
            {
                entity.HasKey(e => e.KisiHareketId);
            });

            modelBuilder.Entity<KisiHareketlerEslesmeyen>(entity =>
            {
                entity.HasKey(e => e.KisiHareketId);
            });

            modelBuilder.Entity<KisiIslemleri>(entity =>
            {
                entity.HasKey(e => e.KisiIslemId);

                entity.Property(e => e.AdSoyad).HasMaxLength(250);

                entity.Property(e => e.Fpindex).HasColumnName("FPIndex");

                entity.Property(e => e.TerminalKartNo).HasMaxLength(50);
            });

            modelBuilder.Entity<KisiIslemleriOzel>(entity =>
            {
                entity.HasKey(e => e.KisiIslemId);

                entity.Property(e => e.AdSoyad).HasMaxLength(250);

                entity.Property(e => e.Fpindex).HasColumnName("FPIndex");

                entity.Property(e => e.TerminalKartNo).HasMaxLength(50);
            });

            modelBuilder.Entity<KisiIzinler>(entity =>
            {
                entity.HasKey(e => e.KisiIzinId)
                    .HasName("PK_KisiIzinler_1");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.EksikSaatEsitle).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaatlikIzin).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KisiKayitlar>(entity =>
            {
                entity.HasKey(e => e.KisiKayitId)
                    .HasName("PK_Kayitlar");
            });

            modelBuilder.Entity<KisiMaasVerileri>(entity =>
            {
                entity.HasKey(e => e.KisiMaasId);
            });

            modelBuilder.Entity<KisiStatuleri>(entity =>
            {
                entity.HasKey(e => e.StatuId)
                    .HasName("PK_Statuler");

                entity.Property(e => e.StatuAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<KisiTemplate>(entity =>
            {
                entity.HasKey(e => e.KisiTempId);

                entity.Property(e => e.Fpindex).HasColumnName("FPIndex");
            });

            modelBuilder.Entity<Kisiler>(entity =>
            {
                entity.HasKey(e => e.KisiId)
                    .HasName("PK_Users");

                entity.Property(e => e.AdSoyad)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.SicilNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SonYemekGunToplami).HasDefaultValueSql("((0))");

                entity.Property(e => e.YemekBakiye).HasDefaultValueSql("((0))");

                entity.Property(e => e.YemekKontor).HasDefaultValueSql("((0))");

                entity.Property(e => e.YillikIzinDevir).HasDefaultValueSql("((0))");

                entity.Property(e => e.YillikIzinGrubuId).HasDefaultValueSql("((0))");

                entity.Property(e => e.YillikIzinKidem).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KullaniciBildirimleri>(entity =>
            {
                entity.HasKey(e => e.KullaniciBildirimId)
                    .HasName("PK_Bildirimler");
            });

            modelBuilder.Entity<KullaniciLoglari>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_UserLogs");
            });

            modelBuilder.Entity<KullaniciYetkileri>(entity =>
            {
                entity.HasKey(e => e.YetkiId)
                    .HasName("PK_Yetkiler");
            });

            modelBuilder.Entity<Kullanicilar>(entity =>
            {
                entity.HasKey(e => e.KullaniciId);

                entity.Property(e => e.ProfilFoto).HasColumnType("image");

                entity.Property(e => e.ZtkartGrubu).HasColumnName("ZTKartGrubu");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.HasKey(e => e.LogId);
            });

            modelBuilder.Entity<MaasVerileri>(entity =>
            {
                entity.HasKey(e => e.MaasId);

                entity.Property(e => e.MaasAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<MolaToleranslari>(entity =>
            {
                entity.HasKey(e => e.MolaToleransId);
            });

            modelBuilder.Entity<OtomatikBakiye>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EskiBakiye).HasColumnName("eski_bakiye");

                entity.Property(e => e.KisiId).HasColumnName("kisi_id");

                entity.Property(e => e.Tutar).HasColumnName("tutar");
            });

            modelBuilder.Entity<OzelRaporAlanlari>(entity =>
            {
                entity.HasKey(e => e.OzelRaporAlanId);
            });

            modelBuilder.Entity<OzelRaporOzellikleri>(entity =>
            {
                entity.HasKey(e => e.OzelRaporOzellikId);
            });

            modelBuilder.Entity<OzelRaporSablonlari>(entity =>
            {
                entity.HasKey(e => e.OzelRaporSablonId);
            });

            modelBuilder.Entity<OzelRaporlar>(entity =>
            {
                entity.HasKey(e => e.OzelRaporId)
                    .HasName("PK_OzelRaporAyarlari");
            });

            modelBuilder.Entity<Periyodlar>(entity =>
            {
                entity.HasKey(e => e.PeriyodId);
            });

            modelBuilder.Entity<PuantajTipleri>(entity =>
            {
                entity.HasKey(e => e.PuantajTipiId);
            });

            modelBuilder.Entity<RaporSablonu>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Text1).HasMaxLength(250);

                entity.Property(e => e.Text2).HasMaxLength(250);

                entity.Property(e => e.Text3).HasMaxLength(250);

                entity.Property(e => e.Text4).HasMaxLength(250);

                entity.Property(e => e.Text5).HasMaxLength(250);

                entity.Property(e => e.Text6).HasMaxLength(250);

                entity.Property(e => e.Text7).HasMaxLength(250);

                entity.Property(e => e.Text8).HasMaxLength(250);
            });

            modelBuilder.Entity<Senaryolar>(entity =>
            {
                entity.HasKey(e => e.SenaryoId);
            });

            modelBuilder.Entity<Sirketler>(entity =>
            {
                entity.HasKey(e => e.SirketId);

                entity.Property(e => e.SirketAdi).HasMaxLength(250);

                entity.Property(e => e.SirketLogo).HasColumnType("image");

                entity.Property(e => e.SirketUnvani).HasMaxLength(250);

                entity.Property(e => e.TelefonNo).HasMaxLength(50);

                entity.Property(e => e.WebSitesi).HasMaxLength(100);
            });

            modelBuilder.Entity<Tatiller>(entity =>
            {
                entity.HasKey(e => e.TatilId);
            });

            modelBuilder.Entity<TerminalGruplari>(entity =>
            {
                entity.HasKey(e => e.TerminalGrupId);

                entity.Property(e => e.GrupAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<TerminalIslemAyarlari>(entity =>
            {
                entity.HasKey(e => e.AyarId);
            });

            modelBuilder.Entity<TerminalIslemleri>(entity =>
            {
                entity.HasKey(e => e.TerminalIslemId)
                    .HasName("PK_TerminalKomutlari");

                entity.Property(e => e.Fpindex).HasColumnName("FPIndex");

                entity.Property(e => e.TerminalKartNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TerminalLoglari>(entity =>
            {
                entity.HasKey(e => e.TerminalLogId);

                entity.Property(e => e.AnaKonu).HasMaxLength(50);

                entity.Property(e => e.CardNo).HasMaxLength(20);

                entity.Property(e => e.Olay).HasMaxLength(100);
            });

            modelBuilder.Entity<TerminalOkuyuculari>(entity =>
            {
                entity.HasKey(e => e.OkuyucuId)
                    .HasName("PK_TerminalKAPI_1");

                entity.Property(e => e.Gc).HasColumnName("GC");
            });

            modelBuilder.Entity<TerminalYetkiGruplari>(entity =>
            {
                entity.HasKey(e => e.TerminalYetkiGrubuId);
            });

            modelBuilder.Entity<Terminaller>(entity =>
            {
                entity.HasKey(e => e.TerminalId);

                entity.Property(e => e.Fpalgoritma)
                    .HasColumnName("FPAlgoritma")
                    .HasMaxLength(10);

                entity.Property(e => e.Ipadres)
                    .HasColumnName("IPAdres")
                    .HasMaxLength(20);

                entity.Property(e => e.Macadres)
                    .HasColumnName("MACAdres")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<UrunFiyatlari>(entity =>
            {
                entity.HasKey(e => e.UrunFiyatId);

                entity.Property(e => e.BayiAlis).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SonKullaniciAlis).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UrunKategorileri>(entity =>
            {
                entity.HasKey(e => e.UrunKategoriId);
            });

            modelBuilder.Entity<UrunOzellikleri>(entity =>
            {
                entity.HasKey(e => e.UrunOzellikId);
            });

            modelBuilder.Entity<UrunParaBirimleri>(entity =>
            {
                entity.HasKey(e => e.UrunParaBirimiId);
            });

            modelBuilder.Entity<UrunTedarikcileri>(entity =>
            {
                entity.HasKey(e => e.UrunTedarikciId);
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.Property(e => e.BayiSatisFiyati).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.MusteriSatisFiyati).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UrunAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<Veri>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdSoyad).HasMaxLength(150);

                entity.Property(e => e.KartNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Yardim>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AltBaslik).HasMaxLength(250);

                entity.Property(e => e.AnaBaslik).HasMaxLength(250);

                entity.Property(e => e.Link).HasMaxLength(250);
            });

            modelBuilder.Entity<YemekGruplari>(entity =>
            {
                entity.HasKey(e => e.YemekGrupId);

                entity.Property(e => e.YemekGrubuAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<YemekOgunAdlari>(entity =>
            {
                entity.HasKey(e => e.OgunAdiId);

                entity.Property(e => e.OgunAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<YemekOgunleri>(entity =>
            {
                entity.HasKey(e => e.OgunId);

                entity.Property(e => e.Ucret).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<YillikIzinGruplari>(entity =>
            {
                entity.HasKey(e => e.YillikIzinGrupId);

                entity.Property(e => e.YillikIzinAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<YillikIzinHakedis>(entity =>
            {
                entity.HasKey(e => e.HakedisId);
            });

            modelBuilder.Entity<Ztayar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTAyar");

                entity.Property(e => e.DurumYenileme).HasMaxLength(10);

                entity.Property(e => e.HareketKontrol).HasMaxLength(1);

                entity.Property(e => e.Hdegisiklik).HasColumnName("HDegisiklik");

                entity.Property(e => e.HkontrolZaman)
                    .HasColumnName("HKontrolZaman")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Ztbeklenenler>(entity =>
            {
                entity.HasKey(e => e.BeklenenId);

                entity.ToTable("ZTBeklenenler");
            });

            modelBuilder.Entity<ZtgeciciKartlar>(entity =>
            {
                entity.HasKey(e => e.GeciciKartId)
                    .HasName("PK__ZTGecici__0D69FDF008EA5793");

                entity.ToTable("ZTGeciciKartlar");
            });

            modelBuilder.Entity<ZtgelisNedenleri>(entity =>
            {
                entity.HasKey(e => e.GelisNedenId);

                entity.ToTable("ZTGelisNedenleri");

                entity.Property(e => e.GelisNedenAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<ZtkaraListe>(entity =>
            {
                entity.HasKey(e => e.KaraListeId);

                entity.ToTable("ZTKaraListe");

                entity.Property(e => e.Aciklama).HasMaxLength(200);

                entity.Property(e => e.KisiAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<ZtkartGruplari>(entity =>
            {
                entity.HasKey(e => e.KartGrubuId);

                entity.ToTable("ZTKartGruplari");
            });

            modelBuilder.Entity<Ztzhareket>(entity =>
            {
                entity.HasKey(e => e.HareketId);

                entity.ToTable("ZTZHareket");

                entity.Property(e => e.Cihaz).HasMaxLength(50);

                entity.Property(e => e.Sicil).HasMaxLength(50);

                entity.Property(e => e.TerminalNo).HasMaxLength(50);
            });

            modelBuilder.Entity<ZtziyaretKartlar>(entity =>
            {
                entity.HasKey(e => e.ZiyaretKartId);

                entity.ToTable("ZTZiyaretKartlar");

                entity.Property(e => e.ZiyaretKartId).HasColumnName("ZiyaretKartID");

                entity.Property(e => e.Durum).HasMaxLength(50);

                entity.Property(e => e.GecisKapi).HasMaxLength(100);

                entity.Property(e => e.KartAdi).HasMaxLength(100);

                entity.Property(e => e.KartNo).HasMaxLength(10);

                entity.Property(e => e.SonKisi).HasMaxLength(150);

                entity.Property(e => e.TerminalNo).HasMaxLength(50);

                entity.Property(e => e.Yer).HasMaxLength(100);
            });

            modelBuilder.Entity<Ztziyaretciler>(entity =>
            {
                entity.HasKey(e => e.ZiyaretciId)
                    .HasName("PK_ZTZIYARETCILER");

                entity.ToTable("ZTZiyaretciler");

                entity.Property(e => e.Aciklama).HasMaxLength(250);

                entity.Property(e => e.AdSoyad).HasMaxLength(100);

                entity.Property(e => e.CepTel).HasMaxLength(50);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.GelisNedeni).HasMaxLength(50);

                entity.Property(e => e.KartAdi).HasMaxLength(100);

                entity.Property(e => e.KartNo).HasMaxLength(11);

                entity.Property(e => e.KimeAd).HasMaxLength(100);

                entity.Property(e => e.KimeSicil).HasMaxLength(50);

                entity.Property(e => e.Nereye).HasMaxLength(10);

                entity.Property(e => e.VatandaslikNo).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
