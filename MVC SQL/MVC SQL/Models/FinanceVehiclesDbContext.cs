using Microsoft.EntityFrameworkCore;
using MVC_SQL.Models.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models
{
    public class FinanceVehiclesDbContext : DbContext
    {
        public DbSet<TestFinanceModel> TestFinanceModelTable { get; set; }
        public DbSet<DailyFinanceModel> DailyFinanceModelTable { get; set; }
        public DbSet<WeeklyFinanceModel> WeeklyFinanceModelTable { get; set; }
        public DbSet<MonthlyFinanceModel> MonthlyFinanceModelTable { get; set; }

    }
}
