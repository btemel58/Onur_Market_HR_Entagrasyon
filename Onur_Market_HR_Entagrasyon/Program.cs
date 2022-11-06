using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Onur_Market_HR_Entagrasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onur_Market_HR_Entagrasyon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddTransient<Timecure_App4Context>();
                    services.AddDbContext<Timecure_App4Context>(options => 
                    options.UseSqlServer("Data Source=37.148.211.210\\SQLEXPRESS,1433;Database=Timecure_App4;Integrated Security=false;User ID=sa;Password=Pdks1234;"), contextLifetime : ServiceLifetime.Singleton);
                    services.AddHostedService<Worker>();
                });
    }
}
