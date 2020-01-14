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

namespace MVC_SQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new TestFinanceModelDbContext())
            {
                var newItem = new TestFinanceModel() { Id = 7 };
                ctx.set.Add(newItem);
                ctx.SaveChanges();
            }
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    public class TestFinanceModelDbContext : DbContext
    {
        public TestFinanceModelDbContext() : base("FinanceDbContext") { }
        public DbSet<TestFinanceModel> set { get; set; }
    }
}
