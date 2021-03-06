﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_SQL.Logic;
using MVC_SQL.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_SQL.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult MyPortfolio()
        {
            using (FinanceVehiclesDbContext con = new FinanceVehiclesDbContext())
            {
                //All elements
                var financeTimeSeriesParentModel = con.FinanceModelSet.Where(f => f.Id >= 0);
                return View(financeTimeSeriesParentModel.Select(x => x).ToList());
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
            if (Logic.DBLogic.DbInterfacer.checkIfDuplicate(getVehicle.CompanyTickerTag))
            {
                return View("AlreadyExists", getVehicle.CompanyTickerTag);
            }
            Models.API_Models.QuoteEndpointModel deserializedVehicleData = null;
            var jsonDict = ApiInterface.JsonFullPop(getVehicle.CompanyTickerTag);

            //Consider that error catching done in this method is wrong. If any of the quote types
            //Returns an error, it may be blocked, but the other quote types won't be blocked.
            try
            {
                deserializedVehicleData = ApiInterface.vehicleFullPop(jsonDict);

            } catch (Exception ex)
            {
                ErrorModel Error = new ErrorModel(ex.Message, ex.StackTrace);
                return View("Error", Error);
            }
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
