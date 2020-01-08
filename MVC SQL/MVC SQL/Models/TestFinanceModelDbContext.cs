using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models
{
    public class TestFinanceModelDbContext : DbContext
    {
        public DbSet<TestFinanceModel> set { get; set; }
    }
}
