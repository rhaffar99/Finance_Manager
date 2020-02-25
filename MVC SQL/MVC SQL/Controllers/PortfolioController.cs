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
                //All elements
                var financeModelList = con.set.Where(f => f.Id >= 0);
                return View(financeModelList.Select(x => x).ToList());
            }
        }
        public IActionResult GetVehicle()
        {
            var getVehicle = new GetVehicleModelBinder();
            return View(getVehicle);
        }

        public IActionResult Test()
        {
            return null;
        }

        //Redirects to form that populates Model Binder
        public IActionResult AddVehicle(GetVehicleModelBinder getVehicle)
        {
            var deserializedVehicleData = new QuoteEndpointModel();
            var json = ApiInterface.generateJsonAsync(getVehicle.CompanyTickerTag, "GLOBAL_QUOTE").Result;
            TestFinanceModel modelToStore = null;
            try
            {
                deserializedVehicleData = ApiInterface.jsonToAPIModelQuote(json);
                modelToStore = new TestFinanceModel(deserializedVehicleData);

            } catch (Exception ex)
            {
                ErrorModel Error = new ErrorModel(ex.Message, ex.StackTrace);
                return View("Error", Error);
            }
                EntityDataHandler.storeData(modelToStore);
            return View(deserializedVehicleData);
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
