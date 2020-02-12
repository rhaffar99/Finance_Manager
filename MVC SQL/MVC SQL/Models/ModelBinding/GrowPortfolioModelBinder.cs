using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models
{
    [BindProperties]
    public class GrowPortfolioModelBinder
    {
        public string CompanyTickerTag { get; set; }
    }
}
