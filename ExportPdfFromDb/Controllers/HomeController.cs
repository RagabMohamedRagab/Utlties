using ExportPdfFromDb.Models;
using ExportPdfFromDb.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExportPdfFromDb.Controllers {
    public class HomeController : Controller {
     

        public IActionResult Index()
        {
            Repository repository = new Repository();
            var bill = repository.Add();
            ViewBag.TotalPrice = repository.TotalPrice().ToString("0.00");
            return View(bill);
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
