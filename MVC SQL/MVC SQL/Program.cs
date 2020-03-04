using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MVC_SQL.Models;
using MVC_SQL.Models.Entity_Models;

namespace MVC_SQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    public class FinanceVehiclesDbContext : DbContext
    {
        public FinanceVehiclesDbContext() : base("FinanceDbContext") { }
        public DbSet<TestFinanceModel> FinanceModelSet { get; set; }
        public DbSet<DailyFinanceModel> DailyFinanceModelSet { get; set; }
        public DbSet<WeeklyFinanceModel> WeeklyFinanceModelSet { get; set; }
        public DbSet<MonthlyFinanceModel> MonthlyFinanceModelSet { get; set; }
    }
}
