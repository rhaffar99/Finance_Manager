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
            //List<customClass> ListOfCustomClass = new List<customClass>();
            //Do as needed...
            //return View(new ListModel<customClass>(ListOfCustomClass));

            //Procure from DB
            //GenericList<TestFinanceModel> portfolioList = 
            return View();
        }
        public IActionResult GrowPortfolio()
        {
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
