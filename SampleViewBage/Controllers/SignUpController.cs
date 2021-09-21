using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Applicationservice;
using Domain.Contract;
using Domain.Entittes;
using Microsoft.AspNetCore.Mvc;

namespace SampleViewBage.Controllers
{
    public class SignUpController : Controller
    {
        IUserFacade userFacade;
        public SignUpController()
        {
            userFacade = new UserFacade();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignIn(User user)
        {
            userFacade.AddUser(user);
            return RedirectToAction("Index","Home");
        }
    }
}