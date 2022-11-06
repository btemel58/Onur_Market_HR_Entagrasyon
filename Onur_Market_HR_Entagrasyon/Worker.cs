using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Onur_Market_HR_Entagrasyon.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Onur_Market_HR_Entagrasyon
{
    public class Worker : BackgroundService
    {
        private readonly Timecure_App4Context _dbContext;

        public Worker(Timecure_App4Context context)
        {
            _dbContext = context;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var token = GetToken();
                var employeelist = GetEmployee(token);
                foreach (var employe in employeelist.result)
                {
                    //todo datayý hazýrla
                    Kisiler k = new Kisiler()
                    {
                        AdSoyad = employe.registerName + " " + employe.registerSurname,
                        SicilNo = employe.registerCode,
                        AktifMi = !employe.ispassive,
                        BelgeNo = employe.employeeId.ToString(),
                        BaslangicT = employe.empDate,
                        AyrilmaT = employe.quitDate,
                        Unvan = employe.titleDesc,
                        FazlaMesaiDurumu = true,
                        OlusturulmaZamani = DateTime.Now,
                        ZiyaretciMi = false,
                        Foto = null,
                        TerminalStatu = 0,
                        TerminalNo = GetMaxTerminalNo(),
                        TerminalSifre = string.Empty,
                        VatandaslikNo = string.Empty,
                        CepTel = string.Empty,
                        Eposta = string.Empty,
                        EvTel = string.Empty,
                        Dahili = string.Empty,
                        Cinsiyet = 0,
                        EgitimDurumu = 0,
                        EhliyetSinifi = string.Empty,
                        AskerlikDurumu = 0,
                        SigaraDurumu = 0,
                        GozlukDurumu = 0,
                        YabanciDil = string.Empty,
                        KanGrubu = string.Empty,
                        Boy = 0,
                        Kilo = 0,
                        Not1 = string.Empty,
                        Not2 = string.Empty,
                        YemekKontor = 0,
                        YemekBakiye = 0.ToString(),
                        AnneAdi = null,
                        BabaAdi = null,
                        BabaCepTel = null,
                        IkametgahAdresi = string.Empty,
                        SorumluKisiId1 = 0,
                        SorumluKisiId2 = 0,
                        SonGecisNoktasi = null,
                        SonGecisZamani = null,
                        SonCikisNoktasi = null,
                        SonCikisZamani = null,
                        SonGecisDurumu = null,
                        EngellilikYuzdesi = string.Empty,
                        DurumId = null,
                        DurumAciklamasi = string.Empty,
                        StatuId = 0,
                        DepartmanId = 0,
                        YemekGrubuId = 0,
                        CalismaGrubuId = 0,
                        OkuyucuYetkileri = string.Empty,
                        TerminalYetkiGrubuId = 0,
                        SirketId = 0,
                        OlusturanKullaniciId = 0,
                        DegisiklikZamani = null,
                        DegisiklikYapanKullaniciId = 0,
                        YillikIzinGrubuId = 0,
                        YillikIzinKidem = 0,
                        YillikIzinDevir = 0,
                        SonYemekOgunu = null,
                        SonYemekGunToplami = null,
                        SonYemekOgunSayisi = null,
                        SonYemekGecisZamani = null,
                        PlakaNumarasi = string.Empty,
                        HgsNo = string.Empty,
                        GecerlilikTarihi = null,
                        DaireId = null,
                        SmsGidecekMi = false,
                        YurttaKaliyorMu = false,
                        VeliCep = string.Empty,
                        OgrenciMi = false,
                        TimezoneKodu = null,
                        MobilKullaniciMi = true,
                        MobilSifre = string.Empty,
                        YemekHakki = false
                    };
                    _dbContext.Kisiler.Add(k);
                    _dbContext.SaveChanges();
                }
                await Task.Delay(60 * 1000, stoppingToken);
            }

        }

        public long GetMaxTerminalNo()
        {
            var data = _dbContext.Kisiler.Max(x => x.TerminalNo);
            return data + 1;
        }
        public Token GetToken()
        {
            var client = new RestClient("http://ozengrupapi.erp.uyumcloud.com:80/UyumApi/v1/GNL/UyumLogin");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonSerializer.Serialize(new TokenRequestBody());
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return JsonSerializer.Deserialize<Token>(response.Content);
        }

        public EmployeeList GetEmployee(Token token)
        {
            var client = new RestClient("http://ozengrupapi.erp.uyumcloud.com:80/UyumApi/v1/HRM/RegisterProfiles");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("UyumSecretKey", token.result.uyumSecretKey);
            request.AddHeader("Authorization", $"Bearer {token.result.access_token}");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return JsonSerializer.Deserialize<EmployeeList>(response.Content);
        }
    }
}
