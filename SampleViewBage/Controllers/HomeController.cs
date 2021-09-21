using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Applicationservice;
using Domain.Contract;
using Microsoft.AspNetCore.Mvc;
using SampleViewBage.Models;

namespace SampleViewBage.Controllers
{
    public class HomeController : Controller
    {
        IProductSliderFacade ProductSliderFacade;
        public HomeController()
        {
            ProductSliderFacade = new ProductSliderFacade();
        }
        public IActionResult Index()
        {
            ViewBag.Prsld = ProductSliderFacade.GetProductSliders();
            return View();
        }
        public PartialViewResult _Menu()
        {
            return PartialView();
        }
        public PartialViewResult _Slider()
        {            
            return PartialView();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
