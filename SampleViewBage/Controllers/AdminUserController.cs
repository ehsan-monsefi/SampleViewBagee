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
    public class AdminUserController : Controller
    {
        IUserFacade userFacade;
        public AdminUserController()
        {
            userFacade = new UserFacade();
        }
        public IActionResult Index()
        {
            ViewBag.Karbar = userFacade.GetUsers();
            return View();
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.EditKarbar = userFacade.GetUser(Id);
            return View();
        }
        [HttpPost]
        public IActionResult Edit1(User user)
        {
            userFacade.EditUser(user);
            return RedirectToAction("Index","AdminUser");
        }
        public IActionResult Delete(User user)
        {
            userFacade.DeleteUser(user);
            return RedirectToAction("Index","AdminUser");
        }
    }
}