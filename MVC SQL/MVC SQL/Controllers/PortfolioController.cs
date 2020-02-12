using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_SQL.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_SQL.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public IActionResult MyPortfolio()
        {
            using (TestFinanceModelDbContext con = new TestFinanceModelDbContext())
            {
                var financeModelList = from model in con.set
                                       select model;
                return View(financeModelList);
            }
        }

        public IActionResult GrowPortfolio()
        {
            //PASS BINDING MODEL
            return View();
        }
        public IActionResult FinanceAnalytics()
        {
            return View();
        }
        public IActionResult Learning()
        {
            return View();
        }
    }
}
