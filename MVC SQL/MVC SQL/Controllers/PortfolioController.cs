﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_SQL.Logic;
using MVC_SQL.Models;
using MVC_SQL.Models.API_Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_SQL.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult MyPortfolio()
        {
            using (TestFinanceModelDbContext con = new TestFinanceModelDbContext())
            {
                var financeModelList = from model in con.set
                                       select model;
                return View(financeModelList);
            }
        }
        public IActionResult GetVehicle()
        {
            var getVehicle = new GetVehicleModelBinder();
            return View(getVehicle);
        }

        //Redirects to form that populates Model Binder
        public IActionResult AddVehicle(GetVehicleModelBinder getVehicle)
        {
            var deserializedVehicleData = new QuoteEndpointModel();
            var json = ApiInterface.generateJsonAsync(getVehicle.CompanyTickerTag).Result;
            deserializedVehicleData = ApiInterface.jsonToAPIModel(json);
            return RedirectToAction("MyPortfolio");
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
